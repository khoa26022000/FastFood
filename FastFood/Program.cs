using FastFood.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FastFood
{
    static class Program
    {
        public static Form1 mainForm = null;
        public static FormLogin loginForm = null;
        public static Register resForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new FormLogin();
            Application.Run(new FormLogin());
        }
    }
}
