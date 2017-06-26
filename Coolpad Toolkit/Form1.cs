using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void download_Click(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (options.SelectedItem == "ROMS")
            {

                roms.Visible = true;
                kernels.Visible = false;
                empty.Visible = false;
            }
            if (options.SelectedItem == "KERNELS")
            {

                roms.Visible = false;
                kernels.Visible = true;
                empty.Visible = false;
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
    }
}
