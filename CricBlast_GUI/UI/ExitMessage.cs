using System;
using System.Management;
using System.Media;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public partial class ExitMessage : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public ExitMessage()
        {
            InitializeComponent();
            SystemSounds.Asterisk.Play();
            Icon = Properties.Resources.CricBlast;
        }

        private void contributionsButton_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string processName = "tiktokLiveApi.exe";
            string query = $"SELECT * FROM Win32_Process WHERE Name = '{processName}'";

            // Connect to WMI and execute the query
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    // Terminate the process
                    obj.InvokeMethod("Terminate", null);
                    Console.WriteLine($"Terminated process: {processName}");
                    Console.WriteLine("\n\nTerminated old API process.\n\n");
                }
            }
            Application.Exit();
        }
    }
}
