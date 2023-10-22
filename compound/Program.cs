using System;
using System.Windows.Forms;

namespace compound
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

        public static void ClosePrompt()
        {
            DialogResult result = MessageBox.Show("Вы хотите закрыть приложение?", "Закрыть", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes) return;
            Application.Exit();
        }
    }
}
