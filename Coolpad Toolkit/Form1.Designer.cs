namespace Coolpad_Toolkit
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.download = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.Label();
            this.options = new System.Windows.Forms.ListBox();
            this.empty = new System.Windows.Forms.ListBox();
            this.roms = new System.Windows.Forms.ListBox();
            this.kernels = new System.Windows.Forms.ListBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.prgDownload = new System.Windows.Forms.ProgressBar();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.App = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(703, 94);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(107, 103);
            this.download.TabIndex = 0;
            this.download.Text = "Click To Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(715, 294);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(81, 26);
            this.about.TabIndex = 1;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(700, 336);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(104, 17);
            this.copyright.TabIndex = 2;
            this.copyright.Text = "CopyRight@Arch";
            this.copyright.Click += new System.EventHandler(this.label1_Click);
            // 
            // options
            // 
            this.options.FormattingEnabled = true;
            this.options.Items.AddRange(new object[] {
            "KERNELS",
            "ROMS",
            "APP"});
            this.options.Location = new System.Drawing.Point(26, 32);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(149, 303);
            this.options.TabIndex = 3;
            this.options.SelectedIndexChanged += new System.EventHandler(this.options_SelectedIndexChanged);
            // 
            // empty
            // 
            this.empty.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.empty.FormattingEnabled = true;
            this.empty.Location = new System.Drawing.Point(196, 66);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(454, 303);
            this.empty.TabIndex = 4;
            // 
            // roms
            // 
            this.roms.FormattingEnabled = true;
            this.roms.Items.AddRange(new object[] {
            "Resurrection Remix",
            "AEX"});
            this.roms.Location = new System.Drawing.Point(196, 32);
            this.roms.Name = "roms";
            this.roms.Size = new System.Drawing.Size(454, 303);
            this.roms.TabIndex = 5;
            this.roms.SelectedIndexChanged += new System.EventHandler(this.roms_SelectedIndexChanged);
            // 
            // kernels
            // 
            this.kernels.FormattingEnabled = true;
            this.kernels.Items.AddRange(new object[] {
            "ZA Kernel",
            "DarkStar Kernel"});
            this.kernels.Location = new System.Drawing.Point(196, 32);
            this.kernels.Name = "kernels";
            this.kernels.Size = new System.Drawing.Size(454, 303);
            this.kernels.TabIndex = 6;
            this.kernels.SelectedIndexChanged += new System.EventHandler(this.kernels_SelectedIndexChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(436, 488);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(85, 26);
            this.btnDownload.TabIndex = 19;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(61, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 26);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(19, 458);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(313, 13);
            this.lblProgress.TabIndex = 17;
            this.lblProgress.Text = "Progress: downloaded 0.00 MB (0 bytes) of 0.00 MB (0 bytes) 0%";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(19, 436);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(207, 13);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status: no item selected for downloading...";
            // 
            // prgDownload
            // 
            this.prgDownload.Location = new System.Drawing.Point(22, 401);
            this.prgDownload.Name = "prgDownload";
            this.prgDownload.Size = new System.Drawing.Size(788, 20);
            this.prgDownload.TabIndex = 15;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(22, 375);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(460, 20);
            this.txtUrl.TabIndex = 14;
            this.txtUrl.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(16, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 100);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Downloading Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(346, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "No options selected...";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // App
            // 
            this.App.FormattingEnabled = true;
            this.App.Items.AddRange(new object[] {
            "Zero Developers App"});
            this.App.Location = new System.Drawing.Point(196, 32);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(454, 303);
            this.App.TabIndex = 22;
            this.App.SelectedIndexChanged += new System.EventHandler(this.App_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(864, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empty);
            this.Controls.Add(this.App);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.prgDownload);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.options);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.about);
            this.Controls.Add(this.download);
            this.Controls.Add(this.kernels);
            this.Controls.Add(this.roms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coolpad Note 3 Universal Hub";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.ListBox options;
        private System.Windows.Forms.ListBox empty;
        private System.Windows.Forms.ListBox roms;
        private System.Windows.Forms.ListBox kernels;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar prgDownload;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox App;
    }
}

