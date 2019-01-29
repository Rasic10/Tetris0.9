using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tetris
{
    public partial class Form2 : Form 
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public int F, dalje, q, pause = 0;
        Random r = new Random();
        figura f;
        Kvadrat k = new Kvadrat();
        Color b;

        void oboji(Color boja)
        {
            for (int i = 0; i < 4; i++)
            {
                Controls["panel" + f.koord[i]].BackColor = boja;
            }
        }   //Zavrseno! -Boji panele u zadatu boju

        void oboji_spusti()
        {
            oboji(Color.White);
            f.dole();
            if ((F == 3) || (F == 5)) oboji(Color.LightBlue);
            if ((F == 2) || (F == 9)) oboji(Color.Green);
            if ((F == 18) || (F == 19)) oboji(Color.Red);
            if (F == 1) oboji(Color.Yellow);
            if ((F == 4) || (F == 6) || (F == 7) || (F == 8)) oboji(Color.OrangeRed);
            if ((F == 10) || (F == 11) || (F == 12) || (F == 13)) oboji(Color.Purple);
            if ((F == 14) || (F == 15) || (F == 16) || (F == 17)) oboji(Color.Blue);
        }   //Zavrseno! -Oboji i spusti figuru

        void popunjeno()
        {
            int i, j, Sc, Sb;
            for (i = 23; i >= 0; )  //bilo je i = 15
            {
                Sc = 0;
                Sb = 0;
                for (j = i * 20 + 1; j <= i * 20 + 20; j++)
                {
                    if (Controls["panel" + j].BackColor != Color.White)
                    {
                        Sc++;
                    }
                    else Sb++;
                }
                if (Sc == 20)
                {
                    label5.Text = (Convert.ToInt32(label5.Text) + 100).ToString();
                    spusti(i);
                }
                else if (Sb == 20)
                {
                    return;
                }
                else i--;
            }
        }   //Zavrseno! -Spusta ako je popunjen neki red

        void spusti(int red)
        {
            int p, q, bele;
            for (p = red; ; p--)
            {
                bele = 0;
                for (q = p * 20 + 1; q < p * 20 + 1 + 20; q++)
                {
                    if ((Controls["panel" + (q - 20)].BackColor) == Color.White)
                    {
                        bele++;
                    }
                    Controls["panel" + q].BackColor = Controls["panel" + (q - 20)].BackColor;
                }
                if (bele == 20)
                {
                    break;
                }
            }
        }   //Zavrseno! -Spusta sva polja dole
        
        void okreni_funkcija(int s0, int s1, int s2, int s3, Color boja)
        {
      //      int zbir;
            Controls["panel" + f.koord[0]].BackColor = Color.White;
      //      unsafe
      //      {
      //          funkcija_zbir(&zbir, f.koord[0], s0);
      //      }
      //      f.koord[0] = zbir;
            f.koord[0] = f.koord[0] + s0;                               //DODATO
            Controls["panel" + f.koord[0]].BackColor = boja;
            Controls["panel" + f.koord[1]].BackColor = Color.White;
     //     f.koord[1] = sabrati_dva_broja(f.koord[1], s1);
            f.koord[1] = f.koord[1] + s1;                               //DODATO
            Controls["panel" + f.koord[1]].BackColor = boja;
            Controls["panel" + f.koord[2]].BackColor = Color.White;
      //      f.koord[2] = sabrati_dva_broja(f.koord[2], s2);
            f.koord[2] = f.koord[2] + s2;                               //DODATO
            Controls["panel" + f.koord[2]].BackColor = boja;
            Controls["panel" + f.koord[3]].BackColor = Color.White;
       //     f.koord[3] = sabrati_dva_broja(f.koord[3], s3);
            f.koord[3] = f.koord[3] + s3;                               //DODATO
            Controls["panel" + f.koord[3]].BackColor = boja;
        }   //Zavrseno! -Pomeranje pozicije figure
        //          -Pozvana funkcija iz projekta C

        void okreni()
        {
            switch (F)
            {
                case 2: okreni_funkcija(20, 1, 18, -1, Color.Green); F = 9; break;
                case 3: okreni_funkcija(-19, 0, 19, 38, Color.LightBlue); F = 5; break;
                case 4: okreni_funkcija(1, -1, -20, -20, Color.OrangeRed); F = 6; break;
                case 5: okreni_funkcija(19, 0, -19, -38, Color.LightBlue); F = 3; break;
                case 6: okreni_funkcija(-2, -19, 0, 19, Color.OrangeRed); F = 7; break;
                case 7: okreni_funkcija(0, 0, -19, -21, Color.OrangeRed); F = 8; break;
                case 8: okreni_funkcija(-19, 0, 19, 2, Color.OrangeRed); F = 4; break;
                case 9: okreni_funkcija(0, 19, 2, 21, Color.Green); F = 2; break;
                case 10: okreni_funkcija(0, 0, 0, 19, Color.Purple); F = 11; break;
                case 11: okreni_funkcija(19, 1, 1, 0, Color.Purple); F = 12; break;
                case 12: okreni_funkcija(-19, 0, 0, 0, Color.Purple); F = 13; break;
                case 13: okreni_funkcija(0, -1, -1, -19, Color.Purple); F = 10; break;
                case 14: okreni_funkcija(19, 19, 1, 1, Color.Blue); F = 15; break;
                case 15: okreni_funkcija(1, -18, 0, 19, Color.Blue); F = 16; break;
                case 16: okreni_funkcija(19, 19, 1, 1, Color.Blue); F = 17; break;
                case 17: okreni_funkcija(-19, 0, 18, -1, Color.Blue); F = 14; break;
                case 18: okreni_funkcija(19, 1, 20, 2, Color.Red); F = 19; break;
                case 19: okreni_funkcija(-19, -1, -20, -2, Color.Red); F = 18; break;
            }
        }   //Zavrseno! -Okrece figuru

        void okreni_2()
        {
            switch (F)
            {
                case 2: okreni_funkcija(21, 2, 19, 0, Color.Green); F = 9; break;
                case 4: okreni_funkcija(2, 0, -19, -19, Color.OrangeRed); F = 6; break;
                case 5:
                    {
                        if (f.koord[0] % 20 == 1) //levo
                        {
                            okreni_funkcija(20, 1, -18, -37, Color.LightBlue);
                            F = 3;
                        }
                        if ((f.koord[0] % 20 == 0) || (f.koord[0] % 20 == 19)) //desno
                        {
                            okreni_funkcija(17, -2, -21, -40, Color.LightBlue);
                            F = 3;
                        }
                        break;
                    }
                case 7: okreni_funkcija(19, 19, 0, -2, Color.OrangeRed); F = 8; break;
                case 11: okreni_funkcija(18, 0, 0, -1, Color.Purple); F = 12; break;
                case 13: okreni_funkcija(1, 0, 0, -18, Color.Purple); F = 10; break;
                case 14: okreni_funkcija(-2, -2, -20, -20, Color.Blue); F = 15; break;
                case 16: okreni_funkcija(20, 20, 2, 2, Color.Blue); F = 17; break;
                case 18: okreni_funkcija(18, 0, 19, 1, Color.Red); F = 19; break;
                default: okreni(); break;
            }
        }   //Zavrseno! -Posebna funkcija za okretanje figure koja je uz ivicu
        
        void provera_4(int kord_0, int kord_1, int kord_2, int kord_3)
        {
            if ((Controls["panel" + kord_0].BackColor == Color.White) && (Controls["panel" + kord_1].BackColor == Color.White) && (Controls["panel" + kord_2].BackColor == Color.White) && (Controls["panel" + kord_3].BackColor == Color.White))
                oboji_spusti();
            else dalje = 1;
        }   //Zavrseno! -Provera pri spustanju

        void provera_3(int kord_0, int kord_1, int kord_2)
        {
            if ((Controls["panel" + kord_0].BackColor == Color.White) && (Controls["panel" + kord_1].BackColor == Color.White) && (Controls["panel" + kord_2].BackColor == Color.White))
                oboji_spusti();
            else dalje = 1;
        }   //Zavrseno! -Provera pri spustanju

        void provera_2(int kord_0, int kord_1)
        {
            if ((Controls["panel" + kord_0].BackColor == Color.White) && (Controls["panel" + kord_1].BackColor == Color.White))
                oboji_spusti();
            else dalje = 1;
        }   //Zavrseno! -Provera pri spustanju

        void provera_1(int kord_0)
        {
            if (Controls["panel" + kord_0].BackColor == Color.White)
                oboji_spusti();
            else dalje = 1;
        }   //Zavrseno! -Provera pri spustanju

        void provera_pri_kreiranju_elementa(int poc, int kraj)
        {
            for (int w = poc; w < kraj; w++)
            {
                if (Controls["panel" + w].BackColor != Color.White)
                {
                    timer1.Stop();
                    label6.Visible = true;
                    q = 1;
                    label1.Enabled = true;
                    label5.Text = "0";
                    break;
                }
            }
        }           //Zavrseno!

        int provera_pri_pomeranju_levo()
        {
            int k = 1;
            switch (F)
            {
                case 1: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] - 1)].BackColor != Color.White)) k = 0; break;
                case 2: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] - 1)].BackColor != Color.White)) k = 0; break;
                case 3: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White)) k = 0; break;
                case 4: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] - 1)].BackColor != Color.White)) k = 0; break;
                case 5: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] - 1)].BackColor != Color.White)) k = 0; break;
                case 6: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] - 1)].BackColor != Color.White)) k = 0; break;
                case 7: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] - 1)].BackColor != Color.White)) k = 0; break;
                case 8: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] - 1)].BackColor != Color.White)) k = 0; break;
                case 9: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] - 1)].BackColor != Color.White)) k = 0; break;
                case 10: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] - 1)].BackColor != Color.White)) k = 0; break;
                case 11: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] - 1)].BackColor != Color.White)) k = 0; break;
                case 12: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] - 1)].BackColor != Color.White)) k = 0; break;
                case 13: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] - 1)].BackColor != Color.White)) k = 0; break;
                case 14: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] - 1)].BackColor != Color.White)) k = 0; break;
                case 15: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] - 1)].BackColor != Color.White)) k = 0; break;
                case 16: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] - 1)].BackColor != Color.White)) k = 0; break;
                case 17: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] - 1)].BackColor != Color.White)) k = 0; break;
                case 18: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] - 1)].BackColor != Color.White)) k = 0; break;
                case 19: if ((Controls["panel" + (f.koord[0] - 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] - 1)].BackColor != Color.White)) k = 0; break;
            }
            if (k == 0)
                return 0;
            else
                return 1;
        }       //Zavrseno! -Ogranicenje da figura ne pokriva figuru sa leve strane

        int provera_pri_pomeranju_desno()
        {
            int k = 1;
            switch (F)
            {
                case 1: if ((Controls["panel" + (f.koord[1] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 2: if ((Controls["panel" + (f.koord[0] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 3: if ((Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 4: if ((Controls["panel" + (f.koord[0] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 5: if ((Controls["panel" + (f.koord[0] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 6: if ((Controls["panel" + (f.koord[0] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 7: if ((Controls["panel" + (f.koord[1] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 8: if ((Controls["panel" + (f.koord[2] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 9: if ((Controls["panel" + (f.koord[0] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] + 1)].BackColor != Color.White)) k = 0; break;
                case 10: if ((Controls["panel" + (f.koord[0] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 11: if ((Controls["panel" + (f.koord[0] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 12: if ((Controls["panel" + (f.koord[2] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 13: if ((Controls["panel" + (f.koord[0] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 14: if ((Controls["panel" + (f.koord[0] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[1] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 15: if ((Controls["panel" + (f.koord[0] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 16: if ((Controls["panel" + (f.koord[1] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 17: if ((Controls["panel" + (f.koord[2] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 18: if ((Controls["panel" + (f.koord[0] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[2] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
                case 19: if ((Controls["panel" + (f.koord[1] + 1)].BackColor != Color.White) || (Controls["panel" + (f.koord[3] + 1)].BackColor != Color.White)) k = 0; break;
            }
            if (k == 0)
                return 0;
            else
                return 1;
        }       //Zavrseno! -Ogranicenje da figura ne pokriva figuru sa desne strane

        int provera_pri_okretanju()
        {
            if ((F == 1) || (F == 3) || (F == 6) || (F == 8) || (F == 9) || (F == 10) || (F == 12) || (F == 15) || (F == 17) || (F == 19)) return 0;
            if (((F == 2) && (f.koord[0] % 20 != 1)) || ((F == 4) && (f.koord[0] % 20 != 1)) || ((F == 5) && (f.koord[0] % 20 != 1) && (f.koord[0] % 20 != 0) && (f.koord[0] % 20 != 19)) || ((F == 7) && (f.koord[1] % 20 != 0)) || ((F == 11) && (f.koord[0] % 20 != 0)) || ((F == 13) && (f.koord[0] % 20 != 1)) || ((F == 14) && (f.koord[0] % 20 != 0)) || ((F == 16) && (f.koord[0] % 20 != 1)) || ((F == 18) && (f.koord[0] % 20 != 0))) return 0;
            return 1;
        }           //Zavrseno! -Otklonjen bag uz ivicu
        
        private void label1_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            for (int y = 1; y < 481; y++)
            {
                Controls["panel" + y].BackColor = Color.White;
            }
            int br = r.Next(1, 20);
            switch (br)
            {
                case 1: f = new Kvadrat(); F = 1; oboji(Color.Yellow); break;
                case 2: f = new Cetvorka1(); F = 2; oboji(Color.Green); break;
                case 3: f = new Linija1(); F = 3; oboji(Color.LightBlue); break;
                case 4: f = new El1(); F = 4; oboji(Color.OrangeRed); break;
                case 5: f = new Linija2(); F = 5; oboji(Color.LightBlue); break;
                case 6: f = new El2(); F = 6; oboji(Color.OrangeRed); break;
                case 7: f = new El3(); F = 7; oboji(Color.OrangeRed); break;
                case 8: f = new El4(); F = 8; oboji(Color.OrangeRed); break;
                case 9: f = new Cetvorka2(); F = 9; oboji(Color.Green); break;
                case 10: f = new T1(); F = 10; oboji(Color.Purple); break;
                case 11: f = new T2(); F = 11; oboji(Color.Purple); break;
                case 12: f = new T3(); F = 12; oboji(Color.Purple); break;
                case 13: f = new T4(); F = 13; oboji(Color.Purple); break;
                case 14: f = new El5(); F = 14; oboji(Color.Blue); break;
                case 15: f = new El6(); F = 15; oboji(Color.Blue); break;
                case 16: f = new El7(); F = 16; oboji(Color.Blue); break;
                case 17: f = new El8(); F = 17; oboji(Color.Blue); break;
                case 18: f = new Cetvorka3(); F = 18; oboji(Color.Red); break;
                case 19: f = new Cetvorka4(); F = 19; oboji(Color.Red); break;
            }
            timer1.Start();
            label1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pause++;
            if (pause % 2 == 1) {
                timer1.Stop();
            } else  {
                timer1.Start();
            }
        }                                    //

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ubrzanje;
            dalje = 0;
            int s0 = f.koord[0] + 20, s1 = f.koord[1] + 20, s2 = f.koord[2] + 20, s3 = f.koord[3] + 20;
            switch (F)
            {
                case 1: provera_2(s2, s3); break;
                case 2: provera_2(s1, s3); break;
                case 3: provera_4(s0, s1, s2, s3); break;
                case 4: provera_2(s2, s3); break;
                case 5: provera_1(s3); break;
                case 6: provera_3(s1, s2, s3); break;
                case 7: provera_2(s0, s3); break;
                case 8: provera_3(s1, s2, s3); break;
                case 9: provera_3(s1, s2, s3); break;
                case 10: provera_3(s1, s2, s3); break;
                case 11: provera_2(s1, s3); break;
                case 12: provera_3(s0, s2, s3); break;
                case 13: provera_2(s2, s3); break;
                case 14: provera_2(s2, s3); break;
                case 15: provera_3(s1, s2, s3); break;
                case 16: provera_2(s1, s3); break;
                case 17: provera_3(s0, s1, s3); break;
                case 18: provera_2(s2, s3); break;
                case 19: provera_3(s0, s2, s3); break;
            }

            if ((f.koord[3] > 460) || (dalje == 1))
            {
                timer1.Stop();
                popunjeno();
                ubrzanje = Convert.ToInt32(label5.Text) / 200;
                timer1.Interval = 500 - 20 * ubrzanje;
                int br = r.Next(1, 20);
                switch (br)
                {
                    case 1: f = new Kvadrat(); F = 1; b = Color.Yellow; break;          //
                    case 2: f = new Cetvorka1(); F = 2; b = Color.Green; break;         //
                    case 3: f = new Linija1(); F = 3; b = Color.LightBlue; break;       //
                    case 4: f = new El1(); F = 4; b = Color.OrangeRed; break;           //
                    case 5: f = new Linija2(); F = 5; b = Color.LightBlue; break;       //
                    case 6: f = new El2(); F = 6; b = Color.OrangeRed; break;           //
                    case 7: f = new El3(); F = 7; b = Color.OrangeRed; break;           //
                    case 8: f = new El4(); F = 8; b = Color.OrangeRed; break;           //
                    case 9: f = new Cetvorka2(); F = 9; b = Color.Green; break;         //
                    case 10: f = new T1(); F = 10; b = Color.Purple; break;             //
                    case 11: f = new T2(); F = 11; b = Color.Purple; break;             //
                    case 12: f = new T3(); F = 12; b = Color.Purple; break;             //
                    case 13: f = new T4(); F = 13; b = Color.Purple; break;             //
                    case 14: f = new El5(); F = 14; b = Color.Blue; break;              //
                    case 15: f = new El6(); F = 15; b = Color.Blue; break;              //
                    case 16: f = new El7(); F = 16; b = Color.Blue; break;              //
                    case 17: f = new El8(); F = 17; b = Color.Blue; break;              //
                    case 18: f = new Cetvorka3(); F = 18; b = Color.Red; break;         //
                    case 19: f = new Cetvorka4(); F = 19; b = Color.Red; break;         //
                }

                q = 0;
                if (F == 3)
                    provera_pri_kreiranju_elementa(9, 12);
                else if ((F == 1) || (F == 6) || (F == 8) || (F == 9) || (F == 10) || (F == 12) || (F == 15) || (F == 17) || (F == 19))
                    provera_pri_kreiranju_elementa(28, 32);
                else if ((F == 2) || (F == 4) || (F == 7) || (F == 11) || (F == 13) || (F == 14) || (F == 16) || (F == 18))
                    provera_pri_kreiranju_elementa(49, 51);
                else if (F == 5)
                    provera_pri_kreiranju_elementa(70, 71);

                if (q != 1)
                {
                    oboji(b);
                    timer1.Start();
                }
                else
                {
                    for (int y = 1; y < 481; y++)
                    {
                        Controls["panel" + y].BackColor = Color.White;
                    }
                    label1.Enabled = true;
                }
            }
        }   

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }                                    //
  
        private void Form2_Load(object sender, EventArgs e)
        {

        }                                      //

        private void Form2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (timer1.Enabled == true)
            {
                oboji(Color.White);
                if (e.KeyCode == Keys.Left)
                {
                    int x = provera_pri_pomeranju_levo();
                    if (x == 1)
                        f.levo();
                }
                if (e.KeyCode == Keys.Right)
                {
                    int y = provera_pri_pomeranju_desno();
                    if (y == 1)
                        f.desno();
                }
                if (e.KeyCode == Keys.Space)
                {
                    int z = provera_pri_okretanju();
                    if (z == 1)
                        okreni_2();
                    else
                        okreni();
                }
                if (e.KeyCode == Keys.Down)
                    timer1.Interval = 50;
                if ((F == 3) || (F == 5)) oboji(Color.LightBlue);
                if ((F == 2) || (F == 9)) oboji(Color.Green);
                if ((F == 18) || (F == 19)) oboji(Color.Red);
                if (F == 1) oboji(Color.Yellow);
                if ((F == 4) || (F == 6) || (F == 7) || (F == 8)) oboji(Color.OrangeRed);
                if ((F == 10) || (F == 11) || (F == 12) || (F == 13)) oboji(Color.Purple);
                if ((F == 14) || (F == 15) || (F == 16) || (F == 17)) oboji(Color.Blue);
            }
        }              //

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.Font = new Font("Snap ITC", 28, FontStyle.Bold);
        }                           //

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font("Snap ITC", 24, FontStyle.Bold);
        }                               //

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Font = new Font("Snap ITC", 28, FontStyle.Bold);
        }                           //

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font("Snap ITC", 24, FontStyle.Bold);
        }                               //

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font("Snap ITC", 20, FontStyle.Bold);
        }                               //

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Font = new Font("Snap ITC", 24, FontStyle.Bold);
        }

        public void Form2_BackgroundImageChanged(object sender, EventArgs e)
        {
            
        }                           //
           
    }
}
