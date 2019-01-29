using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
   public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    //    public Form1 f1 = new Form1();
    //   public Form2 f2 = new Form2();
    //    public Form3 f3 = new Form3();
    //    public Form4 f4 = new Form4();

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Font = new Font("Snap ITC", 28, FontStyle.Bold);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font("Snap ITC", 24, FontStyle.Bold);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.Font = new Font("Snap ITC", 28, FontStyle.Bold);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font("Snap ITC", 24, FontStyle.Bold);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Font = new Font("Snap ITC", 27, FontStyle.Bold);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font("Snap ITC", 24, FontStyle.Bold);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Font = new Font("Snap ITC", 28, FontStyle.Bold);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font("Snap ITC", 24, FontStyle.Bold);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Font = new Font("Snap ITC", 27, FontStyle.Bold);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font("Snap ITC", 24, FontStyle.Bold);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
