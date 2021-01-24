using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson7._2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            GuessTheNumberLogic logic = new GuessTheNumberLogic();
            MainPresenter mainPresenter = new MainPresenter(logic, form);

            Application.Run(form);
        }
    }
}
