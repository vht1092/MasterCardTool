using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MasterCardTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DateTime today = DateTime.Now;
            //if (today.CompareTo(new DateTime(2013, 08, 10, 0, 0, 0)) >= 0)
            //    return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}