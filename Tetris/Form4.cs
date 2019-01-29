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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void label6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Font = new Font("Snap ITC", 24, FontStyle.Bold);
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.Font = new Font("Snap ITC", 28, FontStyle.Bold);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label1.Text = "Tetris elements are game pieces geometric shapes composed of four square blocks each. A random sequence of element fall down the playing field (a rectangular vertical shaft, called the matrix). The objective of the game is to manipulate these elements, by moving each one sideways (if the player feels the need) and rotating it by 90 degree units, with the aim of creating a horizontal line of twenty units without gaps. When such a line is created, it disappears, and any block above the deleted line will fall. When a certain number of lines are cleared, the game enters a new level. As the game progresses, each level causes the elements to fall faster, and the game ends when the stack of elements reaches the top of the playing field and no new elements are able to enter.";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label1.Text = "Elementi tetrisa su geometrijski oblici sastavljeni od po četiri kvadratna bloka. Nasumičnim odabirom elementa koji pada kroz prozor (pravougaonog oblika, nazvanim matrica). Cilj igre je da se manipuliše elementima tako sto se vrši pomeranje po strani (ako igrač oseti potrebu) i rotirajući element za 90 stepeni u cilju stvaranja horizontalne linije od dvadeset polja bez praznih. Kada se kreira takva linija ona nestaje i svaki blok iznad izbrisane linije će pasti. Kada je određen broj linija obrisan igra ulazi u nov nivo. Kako igra napreduje, svaki nivo uzrokuje brži pad elemenata a igra se završava kada mnoštvo elemenata dostigne vrh igre i nema kreiranja novih elemenata.";
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font("Snap ITC", 16, FontStyle.Bold);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Font = new Font("Snap ITC", 20, FontStyle.Bold);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font("Snap ITC", 16, FontStyle.Bold);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Font = new Font("Snap ITC", 20, FontStyle.Bold);
        }
    }
}
