namespace Podcast
{
    partial class Settings
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
            this.settinggroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openfolderbutton = new System.Windows.Forms.Button();
            this.refreshcheckBox = new System.Windows.Forms.CheckBox();
            this.savesettingbutton = new System.Windows.Forms.Button();
            this.cancelsettingbutton = new System.Windows.Forms.Button();
            this.settinggroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settinggroupBox
            // 
            this.settinggroupBox.Controls.Add(this.label1);
            this.settinggroupBox.Controls.Add(this.textBox1);
            this.settinggroupBox.Controls.Add(this.openfolderbutton);
            this.settinggroupBox.Location = new System.Drawing.Point(12, 38);
            this.settinggroupBox.Name = "settinggroupBox";
            this.settinggroupBox.Size = new System.Drawing.Size(337, 153);
            this.settinggroupBox.TabIndex = 0;
            this.settinggroupBox.TabStop = false;
            this.settinggroupBox.Text = "Download Setting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Save Path";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Podcast.Properties.Settings.Default, "SAVEFOLDER", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(116, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(204, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = global::Podcast.Properties.Settings.Default.SAVEFOLDER;
            // 
            // openfolderbutton
            // 
            this.openfolderbutton.Location = new System.Drawing.Point(24, 61);
            this.openfolderbutton.Name = "openfolderbutton";
            this.openfolderbutton.Size = new System.Drawing.Size(86, 23);
            this.openfolderbutton.TabIndex = 0;
            this.openfolderbutton.Text = "Open Folder";
            this.openfolderbutton.UseVisualStyleBackColor = true;
            this.openfolderbutton.Click += new System.EventHandler(this.openfolderbutton_Click);
            // 
            // refreshcheckBox
            // 
            this.refreshcheckBox.AutoSize = true;
            this.refreshcheckBox.Checked = global::Podcast.Properties.Settings.Default.AUTOREFRESH;
            this.refreshcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refreshcheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Podcast.Properties.Settings.Default, "AUTOREFRESH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.refreshcheckBox.Location = new System.Drawing.Point(22, 223);
            this.refreshcheckBox.Name = "refreshcheckBox";
            this.refreshcheckBox.Size = new System.Drawing.Size(270, 16);
            this.refreshcheckBox.TabIndex = 1;
            this.refreshcheckBox.Text = "Refresh when scrollbar reaches the bottom";
            this.refreshcheckBox.UseVisualStyleBackColor = true;
            // 
            // savesettingbutton
            // 
            this.savesettingbutton.Location = new System.Drawing.Point(179, 277);
            this.savesettingbutton.Name = "savesettingbutton";
            this.savesettingbutton.Size = new System.Drawing.Size(75, 23);
            this.savesettingbutton.TabIndex = 3;
            this.savesettingbutton.Text = "OK";
            this.savesettingbutton.UseVisualStyleBackColor = true;
            this.savesettingbutton.Click += new System.EventHandler(this.savesettingbutton_Click);
            // 
            // cancelsettingbutton
            // 
            this.cancelsettingbutton.Location = new System.Drawing.Point(272, 277);
            this.cancelsettingbutton.Name = "cancelsettingbutton";
            this.cancelsettingbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelsettingbutton.TabIndex = 4;
            this.cancelsettingbutton.Text = "CANCEL";
            this.cancelsettingbutton.UseVisualStyleBackColor = true;
            this.cancelsettingbutton.Click += new System.EventHandler(this.cancelsettingbutton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 312);
            this.Controls.Add(this.cancelsettingbutton);
            this.Controls.Add(this.savesettingbutton);
            this.Controls.Add(this.refreshcheckBox);
            this.Controls.Add(this.settinggroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "Settings";
            this.Text = "Settings";
            this.settinggroupBox.ResumeLayout(false);
            this.settinggroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox settinggroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openfolderbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox refreshcheckBox;
        private System.Windows.Forms.Button savesettingbutton;
        private System.Windows.Forms.Button cancelsettingbutton;
    }
}