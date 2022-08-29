using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM_Fortnite_Tool
{
    public partial class DownloadUrlScraperFiles : Form
    {
        public DownloadUrlScraperFiles()
        {
            InitializeComponent();
            startDownload();
        }
        private void startDownload()
        {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("https://tcmtools.com/CheckerStuff/ProxyURLScraperFiles/URLCrawler.rar"), "CrawlerFiles.rar");
            });
            thread.Start();
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                PercentageDone.Value2 = $" {string.Format("{0:0.##}", percentage)}%";
                ProgressFinished.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                PercentageDone.Value2 = "Completed";
                MessageBox.Show("Will Now Open The Downloaded Files, Please Extract them in the program root directory!");
                Process.Start("CrawlerFiles.rar");
                this.Close();
            });
        }
    }
}