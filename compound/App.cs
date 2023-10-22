using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using OfficeOpenXml;
using static OfficeOpenXml.ExcelErrorValue;

namespace compound
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private bool CheckInputs()
        {
            double amount, term, percent;

            bool converted_amount = Double.TryParse(inputAmount.Text, out amount);
            bool converted_term = Double.TryParse(inputTerm.Text, out term);
            bool converted_percent = Double.TryParse(inputPercent.Text, out percent);

            if (!converted_amount || amount <= 0) { 
                MessageBox.Show("Сумма неверная!");
                return false;
            } else if (!converted_term || term < 1 || term > 75)
            {
                MessageBox.Show("Неверный срок!");
                return false;
            } else if (!converted_percent || percent <= 0)
            {
                MessageBox.Show("Неверный процент!");
                return false;
            }

            return true;
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Program.ClosePrompt();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (!CheckInputs()) return;

            double result;
            
            // конвертировать ввод

            double amount, term, annualInterestRate;

            amount = Convert.ToDouble(inputAmount.Value);
            term = Math.Floor(Convert.ToDouble(inputTerm.Value));
            annualInterestRate = Convert.ToDouble(inputPercent.Value) * 0.01;

            // посчитать

            List<double> changesList = new List<double>();
            double toAdd = (double)addEveryTerm.Value;
            result = amount;
            string addtype = addTypeSelector.Text;


            if (selectTypeTerm.Text == "лет")
            {
                for (int year = 1; year <= term; year++)
                {
                    for (int month = 1; month <= 12; month++)
                    {
                        result += result * (annualInterestRate / 12);

                        switch (addtype)
                        {
                            case "ежемесячно":
                                result += toAdd;
                                break;
                            case "ежеквартально":
                                if (month % 3 == 0)
                                {
                                    result += toAdd;
                                }
                                break;
                            case "раз в полгода":
                                if (month % 6 == 0)
                                {
                                    result += toAdd;
                                }
                                break;
                        }
                    }

                    if (addtype == "раз в год")
                    {
                        result += toAdd;
                    }

                    changesList.Add(result);
                }
            } else
            {
                for (int month = 1; month <= term; month++)
                {
                    result += result * (annualInterestRate / 12);

                    switch (addtype)
                    {
                        case "ежемесячно":
                            result += toAdd;
                            break;
                    }

                    changesList.Add(result);
                }
            }

            // отображение графика

            if (exportData.Checked)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Электронные таблицы (*.xlsx)|";
                saveFileDialog.Title = "Сохранить файл";

                if (saveFileDialog.ShowDialog() == DialogResult.OK) // Отобразить диалоговое окно и проверить, была ли нажата кнопка "ОК"
                {
                    string filePath = saveFileDialog.FileName;
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (ExcelPackage excelPackage = new ExcelPackage(filePath))
                    {
                        while (excelPackage.Workbook.Worksheets.Count > 0)
                        {
                            excelPackage.Workbook.Worksheets.Delete(0);
                        }

                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Доход");
                        worksheet.Column(1).Width = 20;
                        worksheet.Column(2).Width = 20;
                        worksheet.Column(3).Width = 31;

                        // заголовки

                        ExcelRange header1 = worksheet.Cells[4, 1];
                        header1.Value = "Текущий год";
                        header1.Style.Font.Bold = true;

                        ExcelRange header2 = worksheet.Cells[4, 2];
                        header2.Value = "Результат за год";
                        header2.Style.Font.Bold = true;

                        ExcelRange header3 = worksheet.Cells[4, 3];
                        header3.Value = "Разница в % от суммы вклада";
                        header3.Style.Font.Bold = true;

                        //

                        ExcelRange ogAmount = worksheet.Cells[1, 1];
                        ogAmount.Value = "Сумма вклада";
                        ogAmount.Style.Font.Bold = true;

                        worksheet.Cells[2, 1].Value = Math.Round(amount, 2);
                        worksheet.Cells[2, 1].Style.Numberformat.Format = "#,##0.00 [$₽-419];-#,##0.00 [$₽-419]";

                        ExcelRange rate = worksheet.Cells[1, 2];
                        rate.Value = "Годовая ставка";
                        rate.Style.Font.Bold = true;

                        worksheet.Cells[2, 2].Value = annualInterestRate;
                        worksheet.Cells[2, 2].Style.Numberformat.Format = "0%";

                        ExcelRange term_cell = worksheet.Cells[1, 3];
                        term_cell.Value = "Срок вклада";
                        term_cell.Style.Font.Bold = true;

                        worksheet.Cells[2, 3].Value = $"{term} {selectTypeTerm.Text}";

                        // объединить

                        ExcelRange space = worksheet.Cells[3, 1, 3, 3];
                        space.Merge = true;

                        // Запись элементов массива в один столбец
                        for (int i = 0; i < changesList.Count; i++)
                        {
                            double value = changesList[i];
                            string formatterm = selectTypeTerm.Text == "лет" ? "год" : "месяц";

                            worksheet.Cells[i + 5, 1].Value = $"{i + 1} {formatterm}"; // первый столбец текущего года

                            // денежная сумма

                            ExcelRange money = worksheet.Cells[i + 5, 2];
                            money.Value = Math.Round(value, 2);
                            money.Style.Numberformat.Format = "#,##0.00 [$₽-419];-#,##0.00 [$₽-419]";

                            // % изменение

                            ExcelRange cell = worksheet.Cells[i + 5, 3];
                            cell.Value = Math.Round(Math.Abs(1 - (changesList[i] / amount)), 4);
                            cell.Style.Numberformat.Format = "0%";
                        }

                        // Сохранение файла
                        FileInfo file = new FileInfo(filePath + ".xlsx");
                        excelPackage.SaveAs(file);
                    }
                }
            }

            // создать результат

            string textresult = "Результат:\n";

            if (selectTypeTerm.Text == "лет")
            {
                for (int i = 0; i < changesList.Count;i++)
                {
                    double value = changesList[i];
                    textresult += $"{i + 1} год = {(value - amount).ToString("C2")}\n";
                }
            } else
            {
                for (int i = 0; i < changesList.Count; i++)
                {
                    double value = changesList[i];
                    textresult += $"{i + 1} месяц = {(value - amount).ToString("C2")}\n";
                }
            }

            string lastChange = changesList.Last().ToString("C2");

            textresult += $"\nДоход: {(changesList.Last() - amount).ToString("C2")}\nИтогвая сумма: {lastChange}\nСумма вклада: {amount.ToString("C2")}";

            // получение формы и графика

            Graph graphForm = new Graph();

            graphForm.Show();
            graphForm.InsertData(changesList, $"{changesList.Count} {selectTypeTerm.Text}", textresult);
        }

        // dragging

        private bool drag = false;
        private Point startPoint = new Point(0, 0);
        internal Menu original;

        void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this.drag) return;

            Point p1 = new Point(e.X, e.Y);
            Point p2 = this.PointToScreen(p1);
            Point p3 = new Point(p2.X - this.startPoint.X,
                                 p2.Y - this.startPoint.Y);

            this.Location = p3;
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Program.ClosePrompt();
        }

        private void ReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.original.Show();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            selectTypeTerm.SelectedIndex = 0;
            addTypeSelector.SelectedIndex = 0;
        }

        private void selectTypeTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = selectTypeTerm.Text;
            addTypeSelector.Items.Clear();
            addTypeSelector.Items.AddRange(type == "мес." ? "ежемесячно".Split(',') : "ежемесячно,ежеквартально,раз в полгода,раз в год".Split(','));
            addTypeSelector.SelectedIndex = 0;
        }
    }
}
