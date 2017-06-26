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
            this.SuspendLayout();
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(741, 134);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(107, 103);
            this.download.TabIndex = 0;
            this.download.Text = "Click To Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(756, 304);
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
            this.copyright.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(723, 333);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(138, 15);
            this.copyright.TabIndex = 2;
            this.copyright.Text = "CopyRight@darkabhi";
            this.copyright.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(860, 389);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.about);
            this.Controls.Add(this.download);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Coolpad Note 3 Universal Hub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Label copyright;
    }
}

