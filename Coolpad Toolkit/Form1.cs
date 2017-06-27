using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coolpad_Toolkit
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Create the file name string.
        string filename;
        // Create the webclient.
        WebClient client = new WebClient();

        private void download_Click(object sender, EventArgs e)
        {

            String filetype = ".zip";
            // Check if the user has entered an url address.
            if (txtUrl.Text == string.Empty)
            {
                // Show error message if messagebox is empty.
                MessageBox.Show("Please select an item, before clicking on Download.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Create a savefiledialog so the user can save the file.
                    SaveFileDialog dialog = new SaveFileDialog();
                    // Select the file type as all files.
                    dialog.Filter = "zip File|*.zip*";
                    // Write the file name for the user.
                    dialog.FileName = filename;
                    // Open the dialog with dialogresult.
                    DialogResult result = dialog.ShowDialog();
                    // Check if the user has clicked OK.
                    if (result == DialogResult.OK)
                    {
                        if (App.SelectedItem == "Zero Developers App")
                        {
                            DownloadFile(txtUrl.Text, dialog.FileName + ".apk");
                        }
                        else
                            // Start the download.
                            DownloadFile(txtUrl.Text, dialog.FileName + filetype);
                    }

                }
                catch
                {
                    // Leave this blank, we don't need an exception message.
                }
            }

        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (options.SelectedItem == "ROMS")
            {

                roms.Visible = true;
                kernels.Visible = false;
                empty.Visible = false;
                label1.Visible = false;
                App.Visible = false;
            }
            if (options.SelectedItem == "KERNELS")
            {

                roms.Visible = false;
                kernels.Visible = true;
                empty.Visible = false;
                label1.Visible = false;
                App.Visible = false;
            }
            if (options.SelectedItem == "APP")
            {

                roms.Visible = false;
                kernels.Visible = false;
                empty.Visible = false;
                label1.Visible = false;
                App.Visible = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed
            Application.Exit();
        }

        private void kernels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void roms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roms.SelectedItem == "Resurrection Remix")
            {
                txtUrl.Text = "https://sourceforge.net/projects/resurrectionremix/files/CP8676_I02/RR-N-v5.8.3-20170608-CP8676_I02-Official.zip/download";
            }
            if (roms.SelectedItem == "AEX")
            {
                txtUrl.Text = "http://downloads.aospextended.com/download/VDVBQWVnLzBuNjFmUDdJdldYNVcxMmNSNzhZcWU5TkJtZjRZeEhrMXpSYz0=";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(textBox1.Text);
            //textBox1.Text = webBrowser1.DocumentText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Create the download void.
        private void DownloadFile(string url, string save)
        {
            // We need to add an using, so we can download another file after the first one completes. If we don't that it will not work.
            using (var client = new WebClient())
            {
                // Run code every time the download changes.
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Changed);
                // Run codes when file download has been completed.
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                // Start the download.
                client.DownloadFileAsync(new Uri(url), save);
            }
        }

        private void Changed(object sender, DownloadProgressChangedEventArgs e)
        {
            // Update the progress bar.
            prgDownload.Value = e.ProgressPercentage;
            // Update status label.
            lblStatus.Text = "Status: downloading...";
            // Update progress label.
            lblProgress.Text = "Progress: downloaded " + (e.BytesReceived / 1024d / 1024d).ToString("0.00 MB") + " (" + e.BytesReceived + " bytes) of " + (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00 MB") + " (" + e.TotalBytesToReceive + " bytes) " + e.ProgressPercentage + "%";
            // Disable Download button.
            btnDownload.Enabled = false;
            // Enable Cancel button.
            btnCancel.Enabled = true;
            // Make the textbox readonly.
            txtUrl.ReadOnly = true;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // Run download canceled codes.
            if (e.Cancelled == true)
            {
                lblStatus.Text = "Status: download canceled.";
            }
            // Run download completed codes.
            else if (e.Cancelled == false)
            {
                lblStatus.Text = "Status: download completed!";
            }
            // Enable Download button.
            btnDownload.Enabled = true;
            // Disabled Cancel button.
            btnCancel.Enabled = false;
            // Reset the progress bar.
            prgDownload.Value = 0;
            // Make the textbox writeable.
            txtUrl.ReadOnly = false;
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Now we are going to create the function, that enter the file name automatically in the savefiledialog.
                Uri uri = new Uri(txtUrl.Text);
                // Save the file name to the string.
                filename = Path.GetFileName(uri.LocalPath);
            }
            catch
            {
                // Leave this blank, we don't need an exception message.
            }
        }
        /*
        private void btnDownload_Click(object sender, EventArgs e)
        {
            // Check if the user has entered an url address.
            if (txtUrl.Text == string.Empty)
            {
                // Show error message if messagebox is empty.
                MessageBox.Show("Please enter an url address, before clicking on Download.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Create a savefiledialog so the user can save the file.
                    SaveFileDialog dialog = new SaveFileDialog();
                    // Select the file type as all files.
                    dialog.Filter = "All Files|*.*";
                    // Write the file name for the user.
                    dialog.FileName = filename;
                    // Open the dialog with dialogresult.
                    DialogResult result = dialog.ShowDialog();
                    // Check if the user has clicked OK.
                    if (result == DialogResult.OK)
                    {
                        // Start the download.
                        DownloadFile(txtUrl.Text, dialog.FileName);
                    }

                }
                catch
                {
                    // Leave this blank, we don't need an exception message.
                }
            }
        }
        */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancel the download.
            client.CancelAsync();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void App_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (App.SelectedItem == "Zero Developers App")
            {
                txtUrl.Text = "https://dc1.androidfilehost.com/dl/jT7uQK4eRuWAMNEqpsT7iA/1498777562/745425885120743740/ZeroDevelopersApp+2.6.2.apk";
            }
        }
    }
}
