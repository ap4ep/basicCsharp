using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson7._1
{
    static class Program
    {
        /// <summary>
        /// 
        /// 1. а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
        /// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
        /// Игрок должен постараться получить это число за минимальное количество ходов.
        /// 
        /// Наумов Илья
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm form = new MainForm();
            DoublerLogic doubler = new DoublerLogic();
            MainHandler handler = new MainHandler(doubler, form);

            Application.Run(form);
        }
    }
}
