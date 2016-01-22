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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void openfolderbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openfolder = new FolderBrowserDialog();
            openfolder.SelectedPath = @"F:\ESL\";
            if (openfolder.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = openfolder.SelectedPath.ToString();
            }
        }

        private void savesettingbutton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SAVEFOLDER = this.textBox1.Text;
            Properties.Settings.Default.AUTOREFRESH = refreshcheckBox.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void cancelsettingbutton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Properties.Settings.Default.SAVEFOLDER;
            this.refreshcheckBox.Checked = Properties.Settings.Default.AUTOREFRESH;
            this.Close();
        }
    }
}
