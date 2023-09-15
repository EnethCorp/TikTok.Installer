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
        public static api KeyAuthApp = new api(
            name: "Tiktok.BallGame",
            ownerid: "qdPVeuvG2s",
            secret: "44d7d1eff612aa588fedfcff6768e97a8fa1ee541a9486a00e1ed7f418fbc244",
            version: "1.0"
        );


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            KeyAuthApp.init();
            autoUpdate();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static void autoUpdate()
        {
            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    Console.WriteLine("\n Auto update avaliable!");
                    Console.WriteLine(" Choose how you'd like to auto update:");
                    Console.WriteLine(" [1] Open file in browser");
                    Console.WriteLine(" [2] Download file directly");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case 2:
                            Console.WriteLine(" Downloading file directly..");
                            Console.WriteLine(" New file will be opened shortly..");

                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            Console.WriteLine(" Invalid selection, terminating program..");
                            Thread.Sleep(1500);
                            Environment.Exit(0);
                            break;
                    }
                }
                Console.WriteLine("\n Status: Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer.");
                Thread.Sleep(2500);
                Environment.Exit(0);
            }
        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;
        }
    }
}
