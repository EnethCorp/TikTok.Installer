using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class Home : UserControl
    {
        public int SelectedMenu = 1;
        private bool _isAvailable = true;

        /* InterTok Vars: */
        /*                */
        public string Game, Username;
        private string LocalLowAppdata, InterTokPath, GamePath;
        /*                */
        /* -------------- */

        public Home(string _Game, string _Username)
        {
            this.Game = _Game;
            this.Username = _Username;
            InitializeComponent();

            UpdateHomeLabels();
            ChangeButtonState(ConnectButton, false);
            ChangeButtonState(StartGameButton, false);
            GetFilePaths();
        }

        /* METHODS */
        private void UpdateHomeLabels()
        {
            Console.WriteLine("\n\n" + Username + "\n\n");
            this.usernameLabel.Text = Username;
        }

        private void ChangeButtonState(Guna2Button button, bool state)
        {
            button.Enabled = state; // Set the button as not clickable
        }
        private void ChangeButtonColor(Guna2Button button, int changeMenu)
        {
            button.FillColor = Color.FromArgb(246, 161, 47);
        }
        private void ChangeImageColor(Guna2CirclePictureBox picture, Color color)
        {
            picture.FillColor = color;
        }
        private void ChangeLabelText(Label label, string _Text)
        {
            label.Text = _Text;
        }

        private void GetFilePaths()
        {
            LocalLowAppdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow");
            Console.Write("\n\n" + LocalLowAppdata + "\n\n");
            InterTokPath = Path.Combine(LocalLowAppdata, "InterTok\\TikTok.") + Game + "\\";
            Console.Write("\n\n" + InterTokPath + "\n\n");
            GamePath = Path.Combine(InterTokPath, "TikTok." + Game + ".exe");
            Console.Write("\n\n" + GamePath + "\n\n");

            if (!File.Exists(GamePath))
            {
                var threadParameters = new ThreadStart(() =>
                {
                    Invoke((Action)(() =>
                    {
                        new MessageBoxDownload("Game is not installed.").ShowDialog();
                        new ChooseTeam(Username).ShowDialog();
                    }));
                });

                var thread = new Thread(threadParameters);
                thread.Start();
            }
        }



        /* BUTTON CLICKS */
        //private void Home_Load(object sender, EventArgs e)
        //{
        //    usernameLabel.Text = Selected.UserDetails[1];
        //    userPhoto.Image = Selected.UserImage;
        //}


        private void tournament_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 6) return;

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    if (Selected.Tournament)
                        homeSubPanel.Controls.Add(value: new TournamentPlay());
                    else
                        homeSubPanel.Controls.Add(value: new TournamentPlayError());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new MessageBoxYesNo(1, "Are you sure you want to log out?").ShowDialog();
            if (!Selected.MessageBoxYesOrNo) return;

            //clearUserDetails();
            Controls.Clear();
            Controls.Add(new Welcome { welcomeLabel = { Text = "Welcome Back!" } });
        }


        private void userPhoto_Click(object sender, EventArgs e)
        {
            //usernameLabel.Text = Selected.UserDetails[1];
            //userPhoto.Image = Selected.UserImage;
        }

        private void GoLive_Click(object sender, EventArgs e)
        {
            ChangeButtonState(GoLiveButton, false);
            System.Threading.Thread.Sleep(1000);
            ChangeLabelText(StateLabel, "Live");
            ChangeImageColor(OnlineIcon, Color.Yellow);
            ChangeButtonState(ConnectButton, true);
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            ChangeButtonState(ConnectButton, false);
            System.Threading.Thread.Sleep(1000);
            ChangeLabelText(StateLabel, "Connected");
            ChangeButtonState(StartGameButton, true);
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(300);
            ChangeLabelText(StateLabel, "Running");
            ChangeImageColor(OnlineIcon, Color.Green);
            ChangeButtonState(StartGameButton, false);
        }
    }
}
