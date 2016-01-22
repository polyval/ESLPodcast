namespace Podcast
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PodcastimageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.podcastsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.infopanel = new System.Windows.Forms.Panel();
            this.PodcastWebListView = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.batchpanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousEpisodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchDownloadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podcastsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PodcastimageList
            // 
            this.PodcastimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PodcastimageList.ImageStream")));
            this.PodcastimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.PodcastimageList.Images.SetKeyName(0, "ESLPodcast.jpg");
            this.PodcastimageList.Images.SetKeyName(1, "Radiolab.jpg");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // podcastsTabControl
            // 
            this.podcastsTabControl.Controls.Add(this.tabPage1);
            this.podcastsTabControl.Controls.Add(this.tabPage2);
            this.podcastsTabControl.Location = new System.Drawing.Point(1, 36);
            this.podcastsTabControl.Name = "podcastsTabControl";
            this.podcastsTabControl.SelectedIndex = 0;
            this.podcastsTabControl.Size = new System.Drawing.Size(1039, 753);
            this.podcastsTabControl.TabIndex = 3;
            this.podcastsTabControl.SelectedIndexChanged += new System.EventHandler(this.podcastsTabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.infopanel);
            this.tabPage1.Controls.Add(this.PodcastWebListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1031, 727);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Podcasts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(475, -2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "Size";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(795, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "Download";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Date";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Episode";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // infopanel
            // 
            this.infopanel.AutoScroll = true;
            this.infopanel.BackColor = System.Drawing.Color.White;
            this.infopanel.Location = new System.Drawing.Point(135, 27);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(899, 697);
            this.infopanel.TabIndex = 7;
            this.infopanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.infopanel_Scroll);
            // 
            // PodcastWebListView
            // 
            this.PodcastWebListView.AutoArrange = false;
            this.PodcastWebListView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PodcastWebListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PodcastWebListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.PodcastWebListView.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PodcastWebListView.LargeImageList = this.PodcastimageList;
            this.PodcastWebListView.Location = new System.Drawing.Point(0, 0);
            this.PodcastWebListView.Margin = new System.Windows.Forms.Padding(1);
            this.PodcastWebListView.MultiSelect = false;
            this.PodcastWebListView.Name = "PodcastWebListView";
            this.PodcastWebListView.Scrollable = false;
            this.PodcastWebListView.Size = new System.Drawing.Size(136, 729);
            this.PodcastWebListView.TabIndex = 1;
            this.PodcastWebListView.UseCompatibleStateImageBehavior = false;
            this.PodcastWebListView.SelectedIndexChanged += new System.EventHandler(this.PodcastWeb_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.batchpanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 727);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Downloads";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // batchpanel
            // 
            this.batchpanel.AutoScroll = true;
            this.batchpanel.BackColor = System.Drawing.Color.White;
            this.batchpanel.Location = new System.Drawing.Point(136, 27);
            this.batchpanel.Name = "batchpanel";
            this.batchpanel.Size = new System.Drawing.Size(899, 697);
            this.batchpanel.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.previousEpisodeToolStripMenuItem,
            this.batchDownloadingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1051, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // previousEpisodeToolStripMenuItem
            // 
            this.previousEpisodeToolStripMenuItem.Name = "previousEpisodeToolStripMenuItem";
            this.previousEpisodeToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.previousEpisodeToolStripMenuItem.Text = "More";
            this.previousEpisodeToolStripMenuItem.ToolTipText = "load previous episode";
            this.previousEpisodeToolStripMenuItem.Click += new System.EventHandler(this.previousEpisodeToolStripMenuItem_Click);
            // 
            // batchDownloadingToolStripMenuItem
            // 
            this.batchDownloadingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.batchDownloadingToolStripMenuItem.Name = "batchDownloadingToolStripMenuItem";
            this.batchDownloadingToolStripMenuItem.Size = new System.Drawing.Size(133, 21);
            this.batchDownloadingToolStripMenuItem.Text = "Batch Downloading";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Enabled = false;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 782);
            this.Controls.Add(this.podcastsTabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Podcast Downloader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.podcastsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList PodcastimageList;
        private System.Windows.Forms.TabControl podcastsTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousEpisodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchDownloadingToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.ListView PodcastWebListView;
        private System.Windows.Forms.Panel batchpanel;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}

