﻿using System;
using System.Windows.Forms;

namespace AAStudio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new MainForm());
//            Application.Run(new ImportImageDialog());
        }
    }
}
