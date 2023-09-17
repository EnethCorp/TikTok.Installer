using System;
using System.Media;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public partial class MessageBoxDownload : Form
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

        public MessageBoxDownload(string message)
        {
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;

            this.message.Text = message;
            SystemSounds.Hand.Play();
            messageMark.Image = Properties.Resources.Error_Mark;
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Selected.MessageBoxYesOrNo = true;
            Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            Selected.MessageBoxYesOrNo = false;
            Close();
        }
    }
}