﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_system
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        public static string user;
        public static string position;
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new logForm());

        }
    }
}
