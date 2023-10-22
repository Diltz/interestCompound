using System;
using System.Drawing;
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

            Calculator main = new Calculator();
            main.original = this;
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
            MessageBox.Show("Программа \"Сложный процентщик\" позволяет быстро рассчитать и удобно вывести данные по вашим предполагаемым вкладам.\r\nДля того чтобы начать работу с программой вам необходимо нажать на кнопку \"В калькулятор\" для перехода на следующую форму.\r\nДалее:\r\n Заполните поля:\r\n  - Сумма вклада\r\n  - Срок вклада (укажите тип срока в выпадающем списке)\r\n  - Годовую доходность (например 7,2)\r\n  - Пополняемость вклада (укажите интервал пополения в выпадающем списке)\r\n\r\n По желанию можно экспортировать данные в Excel для будущей работы с ними, нажав на галочку \"Экспортировать данные в Excel\"\r\n При желании можно вернуться обратно в главное меню нажав справа сверху на значок \"<\"\r\n Чтобы закрыть программу, необходимо в правом верхнем углу нажать на значок \"X\"\r\n\r\nАвтор: Такпешев Николай\r\nДата создания: Май 2023\r\nДата обновления: Октябрь 2023\r\n\r\nЛицензия: MIT\r\nИсходный код: https://github.com/Diltz/interestCompound", "О программе", MessageBoxButtons.OK);
        }
    }
}
