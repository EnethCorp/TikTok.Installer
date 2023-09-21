using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
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
        public static string Game, Username, LocalLowAppdata, InterTokPath, GameFolderPath, GamePath;
        /*                */
        /* -------------- */

        public Home(string _Game, string _Username)
        {
            Game = _Game;
            Username = _Username;
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
                        new MessageBoxDownload("Game is not installed.", 0).ShowDialog();
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
            ChangeLabelText(StateLabel, "Connecting");
            Thread tiktokServerThread = new Thread(() => startTikTokApiLocalServer(Username, Welcome.key));
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


        private WebClient client;
        private bool downloadComplete = true;
        private bool ffmpegComplete = true;

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            if (StateLabel.Text == "Running")
            {
                BeginInvoke((Action)(() => {
                    new MessageBoxOk(Selected.ErrorMark, "Game is running, please stop it before updating", statusError: true).ShowDialog();
                }));
                return;
            }

            /* DELETE ALL GAME FILES */
            System.IO.DirectoryInfo di = new DirectoryInfo(GameFolderPath);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            /* REDOWNLOAD GAME FILES */
            Invoke((Action)(() =>
            {
                new MessageBoxDownload("Update game now?", 2).ShowDialog();
            }));
        }

        private void startTikTokApiLocalServer(string username, string key)
        {
            client = new WebClient();
            string apiPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "api.exe");
            string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");
            // Path.Combine(InterTokPath, "api.exe");


            Console.WriteLine("\n\n" + apiPath + "\n\n");
            Console.WriteLine("\n\n" + ffmpegPath + "\n\n");


            if (!File.Exists(apiPath))
            {
                downloadComplete = false;
                Console.WriteLine("\n\nDOWNLOADING! \n\n");
                // Download tiktok api at "InterTokPath" 
                string url = "https://cdn.discordapp.com/attachments/1136056397038104598/1154068088841584752/tiktokLiveApi.exe";
                Thread thread = new Thread(() =>
                {
                    Uri uri = new Uri(url);
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    client.DownloadFileAsync(uri, apiPath);
                });
                thread.Start();
            }

            while (!downloadComplete)
            {
                Thread.Sleep(300);
            }

 

            if (!File.Exists(ffmpegPath))
            {
                ffmpegComplete = false;
                Console.WriteLine("\n\nDOWNLOADING! \n\n");
                // Download tiktok api at "InterTokPath" 
                string url = "https://cdn.discordapp.com/attachments/1136056397038104598/1154063989924434100/ffmpeg.exe";
                Thread thread = new Thread(() =>
                {
                    Uri uri = new Uri(url);
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChangedFFMPEG);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompletedFFMPEG);
                    client.DownloadFileAsync(uri, ffmpegPath);
                });
                thread.Start();
            }

            while (!ffmpegComplete)
            {
                Thread.Sleep(300);
            }

            Process process = new Process();
            process.StartInfo.FileName = $"{apiPath}"; // Replace with the path to your executable
            process.StartInfo.Arguments = $" {username} {key} {Game}"; // Replace with any command-line arguments

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
                        Console.WriteLine("file content: " + programStatus);
                        if (programStatus == "positive")
                        {
                            Console.WriteLine("POSITIVE:: "+  programStatus);
                            BeginInvoke((Action)(() => {
                                Thread.Sleep(5000);
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
                ChangeImageColor(OnlineIcon, Color.Yellow);
                ChangeLabelText(StateLabel, "Live");
                ChangeButtonState(ConnectButton, true);
                ChangeButtonState(StartGameButton, false);
            }));
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                downloadComplete = true;
            });
        }
        void client_DownloadProgressChangedFFMPEG(object sender, DownloadProgressChangedEventArgs e)
        {

        }
        void client_DownloadFileCompletedFFMPEG(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                ffmpegComplete = true;
            });
        }
    }
}
