using System;
using System.Diagnostics;
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

        public static Home Instance;

        /* InterTok Vars: */
        /*                */
        public string Game, Username, LocalLowAppdata, InterTokPath, GameFolderPath, GamePath;
        /*                */
        /* -------------- */

        public Home(string _Game, string _Username)
        {
            Instance = this;
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
            InterTokPath = Path.Combine(LocalLowAppdata, "InterTok\\");
            Console.Write("\n\n" + InterTokPath + "\n\n");
            GameFolderPath = InterTokPath + "TikTok." + Game + "\\";
            Console.Write("\n\n" + GameFolderPath + "\n\n");
            GamePath = GameFolderPath + "TikTok." + Game + ".exe";
            Console.Write("\n\n" + GamePath + "\n\n");

            if (!File.Exists(GamePath))
            {
                Directory.CreateDirectory(GameFolderPath);

                var threadParameters = new ThreadStart(() =>
                {
                    Invoke((Action)(() =>
                    {
                        new MessageBoxDownload("Game is not installed.").ShowDialog();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new ChooseTeam(Username, Welcome.GameList).ShowDialog();
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
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\TikTok LIVE Studio");
            ChangeButtonState(ConnectButton, true);
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            ChangeButtonState(ConnectButton, false);
            System.Threading.Thread.Sleep(1000);
            ChangeLabelText(StateLabel, "Connected");
            Thread tiktokServerThread = new Thread(() => startTikTokApiLocalServer(this.Username, Welcome.key));
            tiktokServerThread.Start();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(300);
            ChangeLabelText(StateLabel, "Running");
            System.Diagnostics.Process.Start(GamePath);
            ChangeImageColor(OnlineIcon, Color.Green);
            ChangeButtonState(StartGameButton, false);
        }



        private void startTikTokApiLocalServer(string username, string key)
        {
            Process process = new Process();
            process.StartInfo.FileName = "python.exe"; // Replace with the path to your executable
            process.StartInfo.Arguments = $"D:\\Programmieren\\Projekte\\TiktokLive\\TikTok.Installer\\tiktokLiveApi.py {username} {key}, " + Game; // Replace with any command-line arguments

            process.Start();


            Thread checkForSuccess = new Thread(() =>
            {
                string localLowAppdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow");


                string successFile = Path.Combine(localLowAppdata, "InterTok", "TikTok." + Game, "success");
                Console.WriteLine("Success file: " + successFile);
                while (true)
                {
                    if (File.Exists(successFile))
                    {
                        string programStatus = File.ReadAllText(successFile);
                        Console.WriteLine("\n\nfile content: " + programStatus + "\n\n");
                        if (programStatus == "positive")
                        {
                            Console.WriteLine("POSITIVE:: "+  programStatus);
                            BeginInvoke((Action)(() => {
                                ChangeLabelText(StateLabel, "Connected");
                                ChangeButtonState(StartGameButton, true);
                            }));
                        }
                        else
                        {
                            BeginInvoke((Action)(() => {
                                new MessageBoxOk(Selected.ErrorMark, programStatus, statusError: true).ShowDialog();
                            }));

                        }
                        File.Delete(successFile);
                        break;
                    }
                }


            });

            checkForSuccess.Start();

            process.WaitForExit();
            Thread.Sleep(1000);
            int returnValue = process.ExitCode;
            Console.WriteLine($"Api exited with return value: {returnValue}");


            BeginInvoke((Action)(() => {
                ChangeLabelText(StateLabel, "Live");
                ChangeImageColor(OnlineIcon, Color.Yellow);
                ChangeButtonState(ConnectButton, true);
                ChangeButtonState(StartGameButton, false);
            }));
        }
    }
}
