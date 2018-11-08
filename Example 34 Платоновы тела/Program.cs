using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Example_34_Платоновы_тела
{
    static class Program
    {
        public static FormMain formMain;
        public static FormTools formTools;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();
            formTools = new FormTools();
            formTools.Show();
            Application.Run(formMain);
        }
    }
}
