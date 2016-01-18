namespace Podcast
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PodcastWebListView = new System.Windows.Forms.ListView();
            this.PodcastimageList = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.podcastsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.podcastsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            // PodcastimageList
            // 
            this.PodcastimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PodcastimageList.ImageStream")));
            this.PodcastimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.PodcastimageList.Images.SetKeyName(0, "ESLPodcast.jpg");
            this.PodcastimageList.Images.SetKeyName(1, "Radiolab.jpg");
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(132, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(903, 727);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Episode";
            this.columnHeader1.Width = 384;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Download";
            this.columnHeader4.Width = 0;
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
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.PodcastWebListView);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1031, 727);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Podcasts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(791, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 14);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Download";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(794, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 676);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 727);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Downloads";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox2.Location = new System.Drawing.Point(137, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(385, 21);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Episode";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox3.Location = new System.Drawing.Point(590, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 782);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.podcastsTabControl);
            this.Name = "Form1";
            this.Text = "Podcast Downloader";
            this.podcastsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PodcastWebListView;
        private System.Windows.Forms.ImageList PodcastimageList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl podcastsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

