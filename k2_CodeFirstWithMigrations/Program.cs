﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2_CodeFirstWithMigrations
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
            //Application.Run(new Form1());
            Application.Run(new OgrenciEkle());
            //Application.Run(new BolumEkle());
            //Application.Run(new FakulteEkle());
            //Application.Run(new EgitmenEkle());
            //Application.Run(new DersEkle());
        }
    }
}
