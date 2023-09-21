using CricBlast_GUI.UI.Admin_Controls;
using CricBlast_GUI.UI.User_Controls;
using System;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public partial class MessageBoxOk : Form
    {
        bool statusError;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public MessageBoxOk(byte mark, string message, string buttonText = "Ok", bool statusError = false)
        {
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;
            TopMost = true;
            this.message.Text = message;
            okButton.Text = buttonText;
            this.statusError = statusError;
            switch (mark)
            {
                case 0:
                    SystemSounds.Asterisk.Play();
                    messageMark.Image = Properties.Resources.Check_Mark;
                    break;
                case 1:
                    SystemSounds.Exclamation.Play();
                    messageMark.Image = Properties.Resources.Warning_Mark;
                    break;
                default:
                    SystemSounds.Hand.Play();
                    messageMark.Image = Properties.Resources.Error_Mark;
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.message.Text.Equals("You have successfully logged in."))
            {
                /* Login success */
                okButton.Controls.Clear();
                Console.WriteLine("MainPanel: " + MainForm.Instance);
                MainForm.Instance.mainPanel.Controls.Clear();
                //MainForm.Instance.mainPanel.Controls.Add(value: new Welcome());
            }
            else
            {
                /* Login Fail */
                okButton.Controls.Clear();
            }


            Close();
        }
    }
}
