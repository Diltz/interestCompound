using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace compound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool CheckInputs()
        {
            double amount, term, percent;

            bool converted_amount = Double.TryParse(inputAmount.Text, out amount);
            bool converted_term = Double.TryParse(inputTerm.Text, out term);
            bool converted_percent = Double.TryParse(inputPercent.Text, out percent);

            if (!converted_amount || amount < 0) { 
                MessageBox.Show("Сумма неверная!");
                return false;
            } else if (!converted_term || term < 1 || term > 50)
            {
                MessageBox.Show("Неверный срок!");
                return false;
            } else if (!converted_percent || percent < 0)
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

            double amount, term, percent;

            amount = Convert.ToDouble(inputAmount.Text);
            term = Math.Floor(Convert.ToDouble(inputTerm.Text));
            percent = Convert.ToDouble(inputPercent.Text) * 0.01;

            // посчитать

            List<double> changesList = new List<double>();
            result = amount;

            for (int i = 1; i <= term; i++) // проходим текущий год
            {
                for (int month = 1; month <= 12; month++) // разделяем год на 12 месяцев и считаем их процент доходности
                {
                    result += result * (percent / 12);
                }

                changesList.Add(result); // заносим результат текущего года
            }

            // отобразить в таблцие

            string textBoxText = "Результат:\n";

            for (int year = 0; year < changesList.Count; year++)
            {
                textBoxText += $"{year + 1} год - {String.Format("{0:.##}", changesList[year])} руб.\n";
            }

            textBoxText += $"\nНачальная сумма: {amount} руб.\nДоход: {String.Format("{0:.##}", result - amount)} руб.";
            progressTextBox.Text = textBoxText;

            // отображение графика

            if (!createGraphTick.Checked) return;

            // получение формы и графика

            Graph graphForm = new Graph();

            graphForm.Show();
            graphForm.InsertData(changesList, amount);
        }

        // dragging

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

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
    }
}
