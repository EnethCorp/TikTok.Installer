using CricBlast_GUI.UI.User_Controls;
using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Media;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.IO.Compression;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public MessageBoxDownload(string message, int icon)
        {
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;

            this.message.Text = message;
            if (icon == 0)
            {
                SystemSounds.Hand.Play();
                messageMark.Image = Properties.Resources.Error_Mark;
            } 
            else if (icon == 1)
            {
                messageMark.Image = Properties.Resources.Warning_Mark;
            }
            else if (icon == 2)
            {
                messageMark.Image = Properties.Resources.Check_Mark;
            }
        }

        WebClient client;
        string zip_path;

        private void downloadButton_Click(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;

            zip_path = Home.GameFolderPath + "installer.zip";
            Console.Write("\n\n" + zip_path + "\n\n");

            /*
             
                CHANGE FROM MEDIAFIRE BECAUSE IT RATE LIMITS    
            
            */

            string url = "";
            int index = -1;
            switch (Home.Game) {

                case "Plinko":
                    index = 0;
                    break;

                case "Pinball":
                    index = 1;
                    break;

                case "TerritoryWar":
                    index = 2;
                    break;
            }

            string pastebin = new WebClient().DownloadString("https://pastebin.com/raw/NsxaFHfZ");
            using (var reader = new StringReader(pastebin))
            {
                for (int i = 0; i < index; i++)
                {
                    reader.ReadLine();
                }
                url = reader.ReadLine();
            }

           
            Console.Write("\n\n" + pastebin + "\n\n");
            Console.Write("URL: " + url + "\n\n");


            Thread thread = new Thread(() =>
            {
                Uri uri = new Uri(url);
                client.DownloadFileAsync(uri, zip_path);
            });
            thread.Start();
        }
        private void Client_DownloadFileCompleted(Object sender, AsyncCompletedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // If not, invoke this method on the UI thread
                this.Invoke(new Action(() => Client_DownloadFileCompleted(sender, e)));
                return;
            }
            MessageBox.Show("Download complete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /* Unzip the file */
            ZipFile.ExtractToDirectory(zip_path, Home.GameFolderPath);

            /* Delete Zip File */ 
            File.Delete(zip_path);

            /* Close the Window */
            Close();
        }
        private void Client_DownloadProgressChanged(Object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                downloadBar.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                downloadPercentage.Text = String.Format("{0:0.##}", percentage) + "%";
                downloadBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }
    }
}