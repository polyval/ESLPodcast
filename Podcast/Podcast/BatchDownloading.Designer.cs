namespace Podcast
{
    partial class BatchDownloading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.episodecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BatchDownloadingbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.maxPodcast = new System.Windows.Forms.NumericUpDown();
            this.minPodcast = new System.Windows.Forms.NumericUpDown();
            this.ValuetoolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.maxPodcast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPodcast)).BeginInit();
            this.SuspendLayout();
            // 
            // episodecomboBox
            // 
            this.episodecomboBox.ForeColor = System.Drawing.Color.Black;
            this.episodecomboBox.FormattingEnabled = true;
            this.episodecomboBox.Items.AddRange(new object[] {
            "ESL Podcast",
            "English Café"});
            this.episodecomboBox.Location = new System.Drawing.Point(12, 98);
            this.episodecomboBox.Name = "episodecomboBox";
            this.episodecomboBox.Size = new System.Drawing.Size(121, 20);
            this.episodecomboBox.TabIndex = 0;
            this.episodecomboBox.Text = "ESL Podcast";
            this.episodecomboBox.SelectedIndexChanged += new System.EventHandler(this.episodecomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // BatchDownloadingbutton
            // 
            this.BatchDownloadingbutton.Location = new System.Drawing.Point(142, 227);
            this.BatchDownloadingbutton.Name = "BatchDownloadingbutton";
            this.BatchDownloadingbutton.Size = new System.Drawing.Size(60, 23);
            this.BatchDownloadingbutton.TabIndex = 4;
            this.BatchDownloadingbutton.Text = "OK";
            this.BatchDownloadingbutton.UseVisualStyleBackColor = true;
            this.BatchDownloadingbutton.Click += new System.EventHandler(this.BatchDownloadingbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(212, 227);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(60, 23);
            this.Cancelbutton.TabIndex = 5;
            this.Cancelbutton.Text = "CANCEL";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // maxPodcast
            // 
            this.maxPodcast.Location = new System.Drawing.Point(207, 98);
            this.maxPodcast.Maximum = new decimal(new int[] {
            1170,
            0,
            0,
            0});
            this.maxPodcast.Name = "maxPodcast";
            this.maxPodcast.Size = new System.Drawing.Size(42, 21);
            this.maxPodcast.TabIndex = 2;
            this.ValuetoolTip.SetToolTip(this.maxPodcast, "Maximum number of episode");
            this.maxPodcast.Value = new decimal(new int[] {
            1110,
            0,
            0,
            0});
            // 
            // minPodcast
            // 
            this.minPodcast.Location = new System.Drawing.Point(143, 98);
            this.minPodcast.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minPodcast.Name = "minPodcast";
            this.minPodcast.Size = new System.Drawing.Size(42, 21);
            this.minPodcast.TabIndex = 1;
            this.ValuetoolTip.SetToolTip(this.minPodcast, "minimum number is 1");
            this.minPodcast.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BatchDownloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.BatchDownloadingbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxPodcast);
            this.Controls.Add(this.minPodcast);
            this.Controls.Add(this.episodecomboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BatchDownloading";
            this.Text = "BatchDownloading";
            this.Load += new System.EventHandler(this.BatchDownloading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxPodcast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPodcast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox episodecomboBox;
        private System.Windows.Forms.NumericUpDown minPodcast;
        private System.Windows.Forms.NumericUpDown maxPodcast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BatchDownloadingbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.ToolTip ValuetoolTip;

    }
}