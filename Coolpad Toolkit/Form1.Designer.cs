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
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(860, 389);
            this.Controls.Add(this.download);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Coolpad Note 3 Universal Hub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button download;
    }
}

