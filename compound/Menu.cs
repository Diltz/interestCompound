using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compound
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Left = this.Width / 2 - label1.Size.Width / 2;
            label1.Top = this.Height / 2 - label1.Size.Height / 2;
        }

        private void menuClose(object sender, EventArgs e)
        {
            Program.ClosePrompt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 main = new Form1();
            main.Show();
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

        private void author_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сложный процентщик позволяет быстро рассчитать и удобно вывести данные по вашим предполагаемым вкладам.\r\nДля того чтобы начать работу с программой вам необходимо нажать на кнопку Вперёд для перехода на следующую форму с калькулятором.\r\nДалее:\r\n - Заполните поля: Сумма вклада, Срок вклада (в годах), Годовая доходность (например 7,2)\r\n - По желанию можно визуализировать данные нажав на галочку \"Визуализировать данные\"\r\n - Нажмите рассчитать\n\nАвтор: Николай Такпешев\nЛицензия: MIT\nДата создания: Май 2023\nИсходный код: https://github.com/Diltz/interestCompound", "О программе", MessageBoxButtons.OK);
        }
    }
}
