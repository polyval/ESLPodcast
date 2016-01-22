using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast
{
    public partial class BatchDownloading : Form
    {
        public event EventHandler OnBatchDownloading;
        
        public BatchDownloading()
        {
            InitializeComponent();
        }

        public decimal startnumber
        {
            get { return minPodcast.Value; }
        }
        public decimal endnumber
        {
            get { return maxPodcast.Value; }
        }
        private void BatchDownloadingbutton_Click(object sender, EventArgs e)
        {
            if(OnBatchDownloading != null)
            {
                OnBatchDownloading(episodecomboBox.Text, null);
            }
           
        }

        private void BatchDownloading_Load(object sender, EventArgs e)
        {
            maxPodcast.Maximum = Properties.Settings.Default.MAXPODCAST;
            minPodcast.Maximum = Properties.Settings.Default.MAXPODCAST;
            maxPodcast.Value = Properties.Settings.Default.MAXPODCAST;
        }

        private void episodecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.episodecomboBox.SelectedIndex)
            {
                case 0:
                    maxPodcast.Maximum = Properties.Settings.Default.MAXPODCAST;
                    minPodcast.Maximum = Properties.Settings.Default.MAXPODCAST;
                    maxPodcast.Value = Properties.Settings.Default.MAXPODCAST;
                    break;
                case 1:
                    maxPodcast.Maximum = Properties.Settings.Default.MAXECCAFE;
                    minPodcast.Maximum = Properties.Settings.Default.MAXPODCAST;
                    maxPodcast.Value = Properties.Settings.Default.MAXECCAFE;
                    break;
                default:
                    maxPodcast.Maximum = Properties.Settings.Default.MAXPODCAST;
                    break;
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
