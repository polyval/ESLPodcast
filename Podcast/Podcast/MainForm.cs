using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Windows;
using System.Text.RegularExpressions;

namespace Podcast
{
    public partial class MainForm : Form
    {
        
        enum infotype
        {
            Episode,
            Size,
            Date
        };
        enum panel
        {
            panel1,
            panel2,
        };
        
        const string baseurl = "https://www.eslpod.com/website/show_all.php";
        string prefixurl = "https://www.eslpod.com/website/show_all.php?cat_id=-59456&low_rec=";
        int episodeCount = 0;
        int loadmoreCount = 1;
        string savefolder = Properties.Settings.Default.SAVEFOLDER;
        bool autorefresh = Properties.Settings.Default.AUTOREFRESH;
        public MainForm()
        {
            InitializeComponent();
            LoadImage();
        }


        private void PodcastWeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch(this.PodcastWebListView.FocusedItem.ImageIndex)
            //{
            //    case 0:
            //        crawler(baseurl);
            //        break;
            //    case 1:
            //        break;
            //} future use, case 0; eslpod panel is visible, the others are invisible
        }
        private void LoadImage()
        {
            for(int i = 0;i<PodcastimageList.Images.Count;i++)
            {
                var lvi = new ListViewItem();
                lvi.ImageIndex = i;
                PodcastWebListView.Items.Add(lvi);
            }
        }
       
        private void crawler(string downloadurl)
        {
            List<string> episodelist = new List<string>();
            List<string> datelist = new List<string>();
            List<string> urllist = new List<string>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(downloadurl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader stream = new StreamReader(response.GetResponseStream());

            string final_response = stream.ReadToEnd();
            Regex repisode = new Regex(@"class=.podcast_title.>(.+?)</a>");
            Regex rtime = new Regex(@"class=""date-header"">\n(.+?)\s</span>");
            Regex rdownload = new Regex(@"href=""(.+?)""\starget.+Download");
            MatchCollection mtime = rtime.Matches(final_response);
            MatchCollection mepisode = repisode.Matches(final_response);
            MatchCollection mdownload = rdownload.Matches(final_response);

            foreach (Match m in mepisode)
            {
                string sepisode = m.Groups[1].Value;
                episodelist.Add(sepisode);

            }
          
            
            foreach(Match m in mtime)
            {
               string sdate = m.Groups[1].Value;
               sdate = sdate.Trim();
               datelist.Add(sdate);
               
            }
            
            foreach(Match m in mdownload)
            {
                string sdownload = m.Groups[1].Value;
                urllist.Add(sdownload);
            }
            
           

            for (int i = this.episodeCount; i < this.episodeCount+episodelist.Count; i++) //in case of duplication
            {
                string episodetextbox = "episode" + episodeCount.ToString();
                //if (infopanel.Controls.ContainsKey(episodetextbox) == true)
                //{
                //    return;
                //}
                TextBox episodeTextBox = createInfobox(infotype.Episode, i,panel.panel1);
                TextBox dateTextBox =  createInfobox(infotype.Date, i,panel.panel1);
                
                episodeTextBox.Text = episodelist[i-this.episodeCount];
                dateTextBox.Text = datelist[i - this.episodeCount];
                string url = urllist[i - this.episodeCount];
                PictureBox downloadbutton = CreatePicturebox(i);
                downloadbutton.Click += new EventHandler((s, t) => downloadbutton_click(s, t, downloadbutton,url));
                downloadbutton.MouseHover += new EventHandler((s, t) => downloadbutton_MouseHover(s, t, downloadbutton));
                downloadbutton.MouseLeave += new EventHandler((s, t) => downloadbutton_MouseLeave(s, t, downloadbutton));
            }

            this.episodeCount += episodelist.Count;

            if (downloadurl == baseurl)
            {
                GetPodcastsLimit(urllist);
            }
           
        }
        private void GetPodcastsLimit(List<string> urllist)
        {
            Regex reslmax = new Regex(@"eslpod/ESLPod(.+?).mp3");
            Regex recmax = new Regex(@"eslpod/EC(.+?).mp3");
            string url = string.Concat(urllist.ToArray());
            Match meslmax = reslmax.Match(url);
            Match mecmax = recmax.Match(url);
            decimal maxpoadcast = Decimal.Parse(Regex.Match(meslmax.Value, @"\d+").Value);
            decimal maxeccafe = Decimal.Parse(Regex.Match(mecmax.Value, @"\d+").Value);
            Properties.Settings.Default.MAXPODCAST = maxpoadcast;
            Properties.Settings.Default.MAXECCAFE = maxeccafe;
            Properties.Settings.Default.Save();

        }

       private void LoadMore()
       {
           string moreurl = this.prefixurl + (20 * loadmoreCount).ToString();
           crawler(moreurl);
           this.loadmoreCount += 1;
       }
        
        private void downloadbutton_click(object sender, EventArgs e, PictureBox downloadbutton,string url)
        {
            
            int index = Int32.Parse(Regex.Match(downloadbutton.Name, @"\d+").Value);
           
            ProgressBar progressbar = CreateProgressbar(index,panel.panel1);
            PictureBox  cancelbutton = cancelButton(progressbar,panel.panel1);
            
            //url = url.Replace(@"""""", "");
            var tuple = DownloadFile(url, progressbar);
            var myWebClient = tuple.Item1;
            string filename = tuple.Item2;
            cancelbutton.Click+= new EventHandler((s,t)=>cancelbutton_click(s,t,myWebClient,cancelbutton,progressbar,filename)); 
        }
        
        public Tuple<WebClient,string> DownloadFile(string url,ProgressBar progressbar)
        {
            Regex rfilename = new Regex(@"eslpod/(.+)");
            Match mfilename = rfilename.Match(url);
            string filename = mfilename.Groups[1].Value;

            WebClient client = new WebClient();
            // anonymous delegate for passing additional parameter
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(
               (s, t) => ProgressChanged(s, t, progressbar));
            client.DownloadFileCompleted += new AsyncCompletedEventHandler((s, t) => Completed(s, t, client));
            client.DownloadFileAsync(new Uri(url),savefolder+ @"\"+filename );
            var tuple = new Tuple<WebClient,string>(client,savefolder+@"\"+filename);
            return tuple;
        }

        private void ProgressChanged(object sender,DownloadProgressChangedEventArgs e,ProgressBar progressbar)
        {
            progressbar.Value = e.ProgressPercentage;
        }
        private void Completed(object sender, AsyncCompletedEventArgs e,WebClient client)
        {
            if (e.Cancelled == false && e.Error == null) //gets a value indicating whether an asynchronous operation has been canceled
            {
               // System.Windows.Forms.MessageBox.Show("Downloaded One Episode!");
                client.Dispose();
                return;
            }
            if(e.Cancelled)
            {
                client.Dispose();
                return;
            }
        }
        #region create button
        //dynamically create new progressbar
        private ProgressBar CreateProgressbar(int index,panel e)
        {
            ProgressBar progressbar = new ProgressBar();
            progressbar.Width = 150;
            progressbar.Height = 32;
            switch(e)
            {
                case panel.panel1:
                    progressbar.Location = new System.Drawing.Point(700, 32 * index + infopanel.AutoScrollPosition.Y);
                    progressbar.Name = "progressBar" + index.ToString();
                    infopanel.Controls.Add(progressbar); // add controls to a selected tabpage
                    break;
                case panel.panel2:
                    progressbar.Location = new System.Drawing.Point(660, 32 * index + batchpanel.AutoScrollPosition.Y);
                    progressbar.Name = "batchprogressbar" + index.ToString();
                    batchpanel.Controls.Add(progressbar);
                    break;
            }
            
            return progressbar;
        }
        private PictureBox CreatePicturebox(int index)
        {
            PictureBox picturebox = new PictureBox();
            picturebox.Location = new System.Drawing.Point(660,32*index+infopanel.AutoScrollPosition.Y);
            picturebox.Name = "downloadbutton" + index.ToString();
            picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            picturebox.Width = 32;
            picturebox.Height = 32;
            Image downloadbuttonimage = Properties.Resources.downloadbutton;
            picturebox.Image = downloadbuttonimage;
            infopanel.Controls.Add(picturebox);
            return picturebox;

        }
        private  PictureBox cancelButton(ProgressBar progressbar,panel e)
        {
            int progressbarWidth = progressbar.Width;
            int positionX = progressbar.Location.X + progressbarWidth + 5;
            int positionY = progressbar.Location.Y;
            int index = Int32.Parse(Regex.Match(progressbar.Name, @"\d+").Value);
            
            PictureBox picturebox = new PictureBox();
            picturebox.Location = new System.Drawing.Point(positionX, positionY);
            picturebox.Width = 32;
            picturebox.Height = 32;
            Image cancelbuttonimage = Properties.Resources.cancel;
            picturebox.Image = cancelbuttonimage;
            switch(e)
            {
                case panel.panel1:
                    picturebox.Name = "cancelbutton" + index.ToString();
                    infopanel.Controls.Add(picturebox);
                    break;
                case panel.panel2:
                    picturebox.Name = "batchcancelbutton" + index.ToString();
                    batchpanel.Controls.Add(picturebox);
                    break;
            }
            
            return picturebox;
        }
        private TextBox createInfobox(infotype e,int index,panel tab)
        {
            TextBox infobox =new TextBox();
            infobox.BackColor = Color.White;
            infobox.BorderStyle = BorderStyle.None;
            infobox.ReadOnly = true;
            infobox.Height = 32;
            switch(e)
            {
                case infotype.Episode:
                    {
                        infobox.Location = new System.Drawing.Point(5, 11+32 * index+infopanel.AutoScrollPosition.Y);
                        infobox.Name = "episode"+index.ToString();
                        infobox.Width = 400;
                        break;
                    }
                case infotype.Date:
                    {
                        infobox.Location = new System.Drawing.Point(450, 11+32*index+infopanel.AutoScrollPosition.Y);
                        infobox.Name = "date"+index.ToString();
                        infobox.Width = 200;
                        break;
                    }

            }
            if(tab == panel.panel1)
            {
                infopanel.Controls.Add(infobox);
            }
            else
            {
                batchpanel.Controls.Add(infobox);
            }
            return infobox;

        }
        #endregion

        #region event handler
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #region effect
        private void downloadbutton_MouseHover(object sender, EventArgs e, PictureBox downloadbutton)
        {
            downloadbutton.BackColor = Color.GhostWhite;
        }
        private void downloadbutton_MouseLeave(object sender, EventArgs e, PictureBox downloadbutton)
        {
            downloadbutton.BackColor = Color.White;
        }
        #endregion
        private void cancelbutton_click
            (object sender, EventArgs e, WebClient client,PictureBox cancelbutton,
            ProgressBar progressbar,string filename,TextBox episode = null)
        {
            const string message = "确定取消下载么？";
            const string caption = "取消下载";
            if (cancelbutton.Name.StartsWith("batch"))
            {
                client.CancelAsync();
                client.Dispose(); //without it, deleting file would fail.
                batchpanel.Controls.Remove(episode);
                batchpanel.Controls.Remove(cancelbutton);
                batchpanel.Controls.Remove(progressbar);
                cancelbutton.Dispose();
                progressbar.Dispose();
                episode.Dispose();
                File.Delete(filename);
            }
            else 
            {
                var result = System.Windows.Forms.MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    client.CancelAsync();
                    client.Dispose();
                    infopanel.Controls.Remove(cancelbutton);
                    infopanel.Controls.Remove(progressbar);
                    cancelbutton.Dispose();
                    progressbar.Dispose();
                    File.Delete(filename);
                }
            }

        }
        
      
        private void infopanel_Scroll(object sender, ScrollEventArgs e) 
        {
            if(Properties.Settings.Default.AUTOREFRESH == false)
            {
                return;
            }
            if(e.NewValue == infopanel.VerticalScroll.Maximum - infopanel.VerticalScroll.LargeChange +1)
            {
                if(e.NewValue!=e.OldValue) //check if scrollbar is at the bottom
                {
                    LoadMore();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            crawler(baseurl);
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form optionform = new Settings();
            optionform.Show(); //show a child form.
        }

        private void previousEpisodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMore();
        }
        #endregion
        
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatchDownloading batchdownloadform = new BatchDownloading();
            batchdownloadform.OnBatchDownloading += new EventHandler((s, t) => batchdownloadform_ok(s, t, batchdownloadform));
            batchdownloadform.Show();
        }
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  batchpanel.Controls.Clear();
        }

        private void batchdownloadform_ok(object sender, EventArgs e,BatchDownloading batchdownloadform)
        {
            
            int j = 0;

            decimal start = batchdownloadform.startnumber;
            decimal end = batchdownloadform.endnumber;
            string category = (string)sender;
            batchdownloadform.Close();
            startToolStripMenuItem.Enabled = false;
            cancelToolStripMenuItem.Enabled = true;
            

            for (decimal i = start; i <= end; i++)
            {
                batchdownload(i,j,category);
                j++;
            } 

        }
       
        private void batchdownload(decimal i ,int j,string category)
        {
            string eslpodprefix = "http://libsyn.com/media/eslpod/ESLPod";
            string eccafeprefix = "http://libsyn.com/media/eslpod/EC";
            string suffix = ".mp3";
            string url;

            
            if(category == "ESL Podcast")
            {
                url = eslpodprefix + i.ToString() + suffix;
            }
            else
            {
                url = eccafeprefix+ i.ToString() + suffix;
            }
            ProgressBar progressbar = CreateProgressbar(j, panel.panel2);
            TextBox episode = createInfobox(infotype.Episode, j, panel.panel2);
            episode.Text = url;
            PictureBox cancelbutton = cancelButton(progressbar, panel.panel2);
            var tuple = DownloadFile(url, progressbar);
            var myclient = tuple.Item1;
            string filename = tuple.Item2;
            cancelbutton.Click += new EventHandler((s, t) => cancelbutton_click(s, t, myclient, cancelbutton, progressbar,filename));
            cancelToolStripMenuItem.Click += new EventHandler((s, t) => cancelbutton_click(s, t, myclient, cancelbutton, progressbar,filename,episode));
           
        }
        //private bool RemoteFileExists(string url)
        //{
        //    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
        //    request.Method = "HEAD";
        //    request.AllowAutoRedirect = true; //！！！！！！！without it ,always return false
        //    try
        //    {
               
        //        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        //        //response.Close();
        //        if(response.StatusCode != HttpStatusCode.NotFound)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch
        //    {
        //        //Any exception will returns false.
        //        return false;
        //    }
          
        //}
        private void podcastsTabControl_SelectedIndexChanged(object sender, EventArgs e) //share Controls between two tabpages
        {
            PodcastWebListView.Parent = podcastsTabControl.SelectedTab;
            button1.Parent = podcastsTabControl.SelectedTab;
            button2.Parent = podcastsTabControl.SelectedTab;
            button3.Parent = podcastsTabControl.SelectedTab;
            button4.Parent = podcastsTabControl.SelectedTab;
        }
      
    }
}
