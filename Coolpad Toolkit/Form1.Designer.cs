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
            "ROMS"});
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
            this.empty.Location = new System.Drawing.Point(196, 32);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(454, 303);
            this.empty.TabIndex = 4;
            // 
            // roms
            // 
            this.roms.FormattingEnabled = true;
            this.roms.Items.AddRange(new object[] {
            "Resurrection Remix"});
            this.roms.Location = new System.Drawing.Point(196, 32);
            this.roms.Name = "roms";
            this.roms.Size = new System.Drawing.Size(454, 303);
            this.roms.TabIndex = 5;
            this.roms.SelectedIndexChanged += new System.EventHandler(this.roms_SelectedIndexChanged);
            // 
            // kernels
            // 
            this.kernels.FormattingEnabled = true;
            this.kernels.Location = new System.Drawing.Point(196, 32);
            this.kernels.Name = "kernels";
            this.kernels.Size = new System.Drawing.Size(454, 303);
            this.kernels.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(860, 389);
            this.Controls.Add(this.kernels);
            this.Controls.Add(this.roms);
            this.Controls.Add(this.empty);
            this.Controls.Add(this.options);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.about);
            this.Controls.Add(this.download);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
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
    }
}

