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
using System.Text.RegularExpressions;

namespace Podcast
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            LoadImage();
        }


        private void PodcastWeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.PodcastWebListView.FocusedItem.ImageIndex)
            {
                case 0:
                    crawler();
                    break;
                case 1:
                    break;
            }
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
       
        private void crawler()
        {
            List<string> episodelist = new List<string>();
            List<string> datelist = new List<string>();
            List<string> urllist = new List<string>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.eslpod.com/website/show_all.php");
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
          

            for (int i = 0; i < episodelist.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(episodelist[i]);
                lvi.SubItems.Add("");
                lvi.SubItems.Add(datelist[i]);
                lvi.SubItems.Add(urllist[i]);
                listView1.Items.Add(lvi);
                PictureBox downloadbutton = CreatePicturebox(i);
                downloadbutton.Click += new EventHandler((s, t) => downloadbutton_click(s, t, downloadbutton));
                downloadbutton.MouseHover += new EventHandler((s, t) => downloadbutton_MouseHover(s, t, downloadbutton));
                downloadbutton.MouseLeave += new EventHandler((s, t) => downloadbutton_MouseLeave(s, t, downloadbutton));
            }
           
        }

       
        
        private void downloadbutton_click(object sender, EventArgs e, PictureBox downloadbutton)
        {
            
            int index = Int32.Parse(Regex.Match(downloadbutton.Name, @"\d+").Value);
            string url = listView1.Items[index].SubItems[3].Text; //SubItems[3] represents column 3 
            
            ProgressBar progressbar = CreateProgressbar(index);
            PictureBox  cancelbutton = cancelButton(progressbar);
            
            Regex rfilename = new Regex(@"eslpod/(.+)");
            Match mfilename = rfilename.Match(url);
            string filename = mfilename.Groups[1].Value;
            url = url.Replace(@"""""", "");
            WebClient myWebClient = new WebClient();
            // anonymous delegate for passing additional parameter
            myWebClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(
                (s, t) => ProgressChanged(s, t, progressbar));
            myWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            myWebClient.DownloadFileAsync(new Uri(url), @"F:\ESL\" + filename);
            cancelbutton.Click+= new EventHandler((s,t)=>cancelbutton_click(s,t,myWebClient,cancelbutton,progressbar)); 
        }
        
        private void ProgressChanged(object sender,DownloadProgressChangedEventArgs e,ProgressBar progressbar)
        {
            progressbar.Value = e.ProgressPercentage;
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Cancelled == false) //gets a value indicating whether an asynchronous operation has been canceled
            {
                MessageBox.Show("Downloaded One Episode!");
            }
            
        }
        
        //dynamically create new progressbar
        private ProgressBar CreateProgressbar(int index)
        {
            ProgressBar progressbar = new ProgressBar();
            progressbar.Location = new System.Drawing.Point(40, 33*index);
            progressbar.Name = "progressBar" + index.ToString();
            progressbar.Width = 150;
            progressbar.Height = 32;
            panel1.Controls.Add(progressbar); // add controls to a selected tabpage
            return progressbar;
        }
        private PictureBox CreatePicturebox(int index)
        {
            PictureBox picturebox = new PictureBox();
            picturebox.Location = new System.Drawing.Point(0,33*index);
            picturebox.Name = "downloadbutton" + index.ToString();
            picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            picturebox.Width = 32;
            picturebox.Height = 32;
            Image downloadbuttonimage = Properties.Resources.downloadbutton;
            picturebox.Image = downloadbuttonimage;
            panel1.Controls.Add(picturebox);
            return picturebox;

        }
        private  PictureBox cancelButton(ProgressBar progressbar)
        {
            int progressbarWidth = progressbar.Width;
            int positionX = progressbar.Location.X + progressbarWidth + 5;
            int positionY = progressbar.Location.Y;
            int index = Int32.Parse(Regex.Match(progressbar.Name, @"\d+").Value);
            
            PictureBox picturebox = new PictureBox();
            picturebox.Location = new System.Drawing.Point(positionX, positionY);
            picturebox.Name = "cancelbutton" + index.ToString();
            picturebox.Width = 32;
            picturebox.Height = 32;
            Image cancelbuttonimage = Properties.Resources.cancel;
            picturebox.Image = cancelbuttonimage;
            panel1.Controls.Add(picturebox);
            return picturebox;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void downloadbutton_MouseHover(object sender, EventArgs e, PictureBox downloadbutton)
        {
            Image originpic = Properties.Resources.downloadbutton;
            int downloadbutton_Width = originpic.Width + ((originpic.Width * 20) / 100);
            int downloadbutton_Height = originpic.Height + ((originpic.Height * 20) / 100);
           
            Bitmap downloadbutton_1 = new Bitmap(downloadbutton_Width, downloadbutton_Height);
            Graphics g = Graphics.FromImage(downloadbutton_1);
            g.DrawImage(originpic, new Rectangle(Point.Empty,downloadbutton_1.Size));
            downloadbutton.Image = downloadbutton_1;
            downloadbutton.BackColor = Color.GhostWhite;
        }
        private void downloadbutton_MouseLeave(object sender, EventArgs e, PictureBox downloadbutton)
        {
            downloadbutton.BackColor = Color.White;
        }
        private void cancelbutton_click(object sender, EventArgs e, WebClient client,PictureBox cancelbutton,ProgressBar progressbar)
        {
            const string message = "确定取消下载么？";
            const string caption = "取消下载";
            var result = MessageBox.Show(message,caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                client.CancelAsync();
                panel1.Controls.Remove(cancelbutton);
                panel1.Controls.Remove(progressbar);
            }
                
        }
        
    }
}
