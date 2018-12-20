using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace CustomfightLauncher
{
    public partial class Form1 : Form
    {
        const string SERVER_VERSION = "http://version.midea-entertainment.com:60001/version.txt";
        const string SERVER_STATUS = "http://version.midea-entertainment.com:60001/status.txt";
        const string SERVER_NEWS = "http://version.midea-entertainment.com:60001/news.txt";
        const string UPDATER = "http://updates.midea-entertainment.com:60000/Midealauncherupdater.exe";
        const string SERVER_LAUNCHERVERSION = "http://version.midea-entertainment.com:60001/launcherversion.txt";
        const string LAUNCHER = "http://updates.midea-entertainment.com:60000/MideaLauncher.exe";
        const string SERVER_ROOT = "http://updates.midea-entertainment.com:60000/";

        string path = Path.GetDirectoryName(Application.ExecutablePath);
        int countD;
        int countM;
        int countLD;
        string versionSrv = "";

        public Form1()
        {
            InitializeComponent();
            countD = 0;
            countM = 0;
            countLD = 0;
            richTextBoxNews.Text = GetServerData(SERVER_NEWS);
            SetServerStatus();
            versionLabel.Text = "Gameversion: " + GetLocalVersion();
            launcherVersionLabel.Text = "Launcherversion:" + GetLocalLauncherVersion();
            if (!CheckLauncherVersion())
            {
                MessageBox.Show("A new launcher update is available. It will update now.");
                btnStart.Enabled = false;
                DownloadLauncher();
            }
            else
            {
                if (!CheckVersion())
                {
                    btnStart.BackColor = Color.Yellow;
                    btnStart.Text = "Update";
                }
                
            }
        }

        #region Launcher


        private string GetServerData(string data)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(data);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Some data couldnt be load. Fileserver might be down. Please try again later");
                ExceptionLogger(this, e);
                return "";
            }
        }

        private bool CheckLauncherVersion()
        {
            string version = GetLocalLauncherVersion();
            string versionSrv = GetServerData(SERVER_LAUNCHERVERSION);
            if (version == versionSrv)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetLocalLauncherVersion()
        {
            if (File.Exists(path + "\\launcherversion.txt"))
            {
                StreamReader file = new StreamReader(path + "//launcherversion.txt");
                string locallauncherversion = file.ReadLine();
                file.Close();
                return locallauncherversion;
            }
            else
            {
                return "";
            }
        }

        private void DownloadLauncher()
        {
            string pathDownload = path + "\\Download";
            Console.WriteLine(pathDownload);
            WebClient client = new WebClient();

            List<string> launcherpathList = new List<string>
            {
                SERVER_LAUNCHERVERSION,
                LAUNCHER
            };

            List<string> launcherfilenameList = new List<string>
            {
                pathDownload + "\\" + Path.GetFileName(launcherpathList[0]),
                pathDownload + "\\" + Path.GetFileName(launcherpathList[1]),
            };

            client.DownloadFileCompleted += (s, e) =>
            {
                DownloadLauncher();
            };

            if (countLD < launcherpathList.Count)
            {
                try
                {
                    client.DownloadFileAsync(new Uri(launcherpathList[countLD]), launcherfilenameList[countLD]); // hier warten bis download fertig
                    countLD++;
                }
                catch (Exception e)
                {
                    ExceptionLogger(this, e);
                }  
            }
            else
            {
                RunUpdater();
            }
        }//DownloadLauncher()

        private void RunUpdater()
        {
            Process p = new Process();
            p.StartInfo.FileName = "Midealauncherupdater.exe";
            try
            {
                p.Start();
                Application.Exit();
            }
            catch (Exception e)
            {
                MessageBox.Show("Midealauncherupdater couldnt be found. Please make sure you have your client correctly installed.");
                ExceptionLogger(this, e);
            }
        }

        private void ExceptionLogger(object sender, Exception e)
        {
            string logPath = path + "\\MideaLauncherLog.txt";
            using (StreamWriter file = new StreamWriter(logPath, true))
            {
                file.WriteLine("[" + DateTime.Now + "]" + sender + " throws exception: " + e);
            }
        }

        #endregion

        #region Game
        private string GetLocalVersion()
        {
            if (File.Exists(path + "\\version.txt"))
            {
                StreamReader file = new StreamReader(path + "//version.txt");
                string localversion = file.ReadLine();
                file.Close();
                return localversion;
            }
            else
            {
                return "";
            }
            
        }

        private void Main()
        {
            bool VersionOk = CheckVersion();
            if (VersionOk)
            {
                RunExtProg();
            }
            else
            {
                progressBar.Visible = true;
                btnStart.BackColor = Color.Red;
                btnStart.Enabled = false;
                bool downloadOk = Download(countD);
                if (downloadOk)
                {
                    System.Threading.Thread.Sleep(500);
                    BackgroundMoveFiles.RunWorkerAsync(); 
                }
            }
        }

        private bool CheckVersion()
        {
            versionSrv = GetServerData(SERVER_VERSION);
            string version = GetLocalVersion();
            if (version == versionSrv)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Download(int itemNumber)
        {
            string pathDownload = path + "\\Download";
            Console.WriteLine(pathDownload);

            List<string> pathList = new List<string>
            {
                SERVER_VERSION,
                SERVER_ROOT + versionSrv + "/data.fdb",
                SERVER_ROOT + versionSrv + "/update.inf",
                SERVER_ROOT + versionSrv + "/RuneDev.ini",
                UPDATER

            };

            WebClient client = new WebClient();
            client.DownloadProgressChanged += (s, e) =>
            {
                progressBar.Value = e.ProgressPercentage;
                progressLabel.Text = "Progress: " + e.ProgressPercentage + "%";
            };
            client.DownloadFileCompleted += (s, e) =>
            {
                Main();
            };

            if (itemNumber < pathList.Count)
            {
                client.DownloadFileAsync(new Uri(pathList[itemNumber]), pathDownload + "\\" + Path.GetFileName(pathList[itemNumber])); // hier warten bis download fertig
                itemNumber++;
                countD = itemNumber;
            }
            else
            {
                return true;
            }
            return false;
        }

        private void BackgroundMoveFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            int itemNumber = 0;
            List<string> sourcePathList = new List<string>
            {
                path + "\\Download\\data.fdb",
                path + "\\Download\\update.inf",
                path + "\\Download\\Midealauncherupdater.exe",
                path + "\\Download\\RuneDev.ini",
                //insert new paths here
                path + "\\Download\\version.txt"
            };

            List<string> targetPathList = new List<string>
            {
                path + "\\fdb\\data.fdb",
                path + "\\update.inf",
                path + "\\Midealauncherupdater.exe",
                path + "\\RuneDev.ini",
                //insert new paths here
                path + "\\version.txt"
            };

            while (itemNumber < sourcePathList.Count)
            {
                File.Copy(sourcePathList[itemNumber], targetPathList[itemNumber], true);   //copy & overwrite if it already exists
                itemNumber++;
                countM = itemNumber;
            }
        }

        private void BackgroundMoveFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            versionLabel.Text = "Gameversion: " + GetLocalVersion();
            btnStart.Enabled = true;
            btnStart.BackColor = Color.ForestGreen;
            progressBar.Visible = false;
            progressLabel.Visible = false;
            RunExtProg();
        }

        private void BackgroundMoveFiles_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressLabel.Text = "Moving Files " + e.ProgressPercentage + "%";
        }

        private void RunExtProg()
        {
            string clientpath = path + "\\client.exe";
            if (File.Exists(clientpath))
            {
                try
                {
                    File.Move(clientpath, path + "\\Midea.exe");
                }
                catch (Exception e)
                {
                    ExceptionLogger(this, e);
                }
            }

            Process p = new Process();
            p.StartInfo.FileName = "Midea.exe";
            p.StartInfo.Arguments = "NoCheckVersion";

            try
            {
                p.Start();
                Application.Exit();
            }
            catch (Exception e)
            {
                ExceptionLogger(this, e);
                MessageBox.Show("Program couldnt be started." + Environment.NewLine + Environment.NewLine + "The name must be 'Midea.exe' and the file should be in the same folder as MideaLauncher.exe ! ");
            }
        }//runExtProg()

        #endregion

        #region Form

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void SetServerStatus()
        {
            string status = GetServerData(SERVER_STATUS);
            onlineLabel.Text = status;
            if (status == "Online" || status == "online")
            {
                onlineLabel.ForeColor = Color.Lime;
            }
            else
            {
                onlineLabel.ForeColor = Color.Red;
            }
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void ForumLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customfight.xobor.de/");
        }

        private void ChangelogLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customfight.xobor.de/f7-Patch-Notes.html");
        }

        private void WebsiteLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://customfight.website2.me//");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
