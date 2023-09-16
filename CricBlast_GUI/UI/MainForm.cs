using System;
using System.Windows.Forms;
using CricBlast_GUI.Database;
using CricBlast_GUI.UI.User_Controls;

namespace CricBlast_GUI.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;
            if (Instance == null)
            {
                Instance = this;
            }
        }

        private void GetStarted_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(value: new Welcome());
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            new ExitMessage().ShowDialog();
        }
    }
}