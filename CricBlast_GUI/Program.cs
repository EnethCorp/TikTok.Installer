using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using CricBlast_GUI.UI;
using KeyAuth;


namespace CricBlast_GUI
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
        }
    }
}
