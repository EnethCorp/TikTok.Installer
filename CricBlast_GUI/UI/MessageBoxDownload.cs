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

        WebClient client;
        string zip_path;

        private void downloadButton_Click(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;

            zip_path = Home.Instance.GameFolderPath + "installer.zip";
            Console.Write("\n\n" + zip_path + "\n\n");

            /*
             
                CHANGE FROM MEDIAFIRE BECAUSE IT RATE LIMITS    
            
            */

            string url = "https://ucb510f9946f56e05bf87b7c35f4.dl.dropboxusercontent.com/cd/0/get/CD7ZU0v1smPb_3ffldNhVypwEG7tAatvA2q0L3azP2ex_NEYYTDSTV8UD5VdadohMEqmldZTHuWkH4T9GYJgFE_OkaLu4giL5mekeG0UjfPVACvJracU1KuiEK9sxbfrdqu0zCWxWPwd8mco4oYsf9fqIGIRmz08oLUoMOtHB4ZwyQ/file#";
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
            ZipFile.ExtractToDirectory(zip_path, Home.Instance.GameFolderPath);

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