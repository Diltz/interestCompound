using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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

            if (!converted_amount) { 
                MessageBox.Show("Сумма неверная! Пример: 100000");
                return false;
            } else if (!converted_term)
            {
                MessageBox.Show("Неверный срок! Пример: 10");
                return false;
            } else if (!converted_percent)
            {
                MessageBox.Show("Неверный процент! Пример: 24");
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
            term = Convert.ToDouble(inputTerm.Text);
            percent = Convert.ToDouble(inputPercent.Text) * 0.01;

            // посчитать

            List<double> changesList = new List<double>();
            result = amount;

            for (int i = 1; i <= term; i++)
            {
                double earning = result * percent;

                result += earning;
                changesList.Add(earning);
            }

            MessageBox.Show(Convert.ToInt32(Math.Round(result)).ToString());

            
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
