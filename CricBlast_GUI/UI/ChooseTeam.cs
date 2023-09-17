using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Teams.Team;


namespace CricBlast_GUI.UI
{
    public partial class ChooseTeam : Form
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

        private string TempUsername;

        public ChooseTeam(string _Username)
        {
            this.TempUsername = _Username;
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;
            
        }

        public ChooseTeam(List<string> optionFields)
        {
            this.optionFields = optionFields;
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;
        }


        private void ChooseTeam_Load(object sender, EventArgs e)
        {
            teamComboBox.SelectedIndex = Selected.UserTeam == 0 ? 0 : Selected.UserTeam;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (teamComboBox.SelectedIndex == 0)
            {
                teamSelectError.Visible = true;
                return;
            }

            string Game = (string)teamComboBox.Items[teamComboBox.SelectedIndex];
            Console.WriteLine("\n\n\n" + Game + "\n\n\n");

            Controls.Clear();
            Console.WriteLine("MainPanel: " + MainForm.Instance);
            MainForm.Instance.mainPanel.Controls.Clear();
            MainForm.Instance.mainPanel.Controls.Add(value: new Home(Game, TempUsername));

            Close();
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamSelectError.Visible = teamComboBox.SelectedIndex == 0;
        }

        public static int TeamNumber(ComboBox selectedTeam)
        {
            switch (selectedTeam.SelectedItem.ToString().Trim())
            {
                case "Australia":
                    return 1;
                case "Bangladesh":
                    return 2;
                case "India":
                    return 3;
                case "New Zealand":
                    return 4;
                case "Pakistan":
                    return 5;
                case "South Africa":
                    return 6;
                case "Sri Lanka":
                    return 7;
                case "West Indies":
                    return 8;
                default:
                    return 0;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}