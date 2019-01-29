using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tetris
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font("Snap ITC", 24, FontStyle.Bold);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.Font = new Font("Snap ITC", 28, FontStyle.Bold);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.linkedin.com/in/rasicn");   
        }
    }
}
