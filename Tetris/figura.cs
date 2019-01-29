using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class figura
    {
        public int[] koord = new int[4];
        public void dole()
        {
            for (int i = 0; i < 4; i++)
            {
                koord[i] = koord[i] + 20;
            }
        }
        public bool desno()
        {
            for (int i = 0; i < 4; i++)
            {
                if (koord[i] % 20 == 0)
                {
                    return false;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                koord[i] = koord[i] + 1;
            }
            return true;

        }
        public bool levo()
        {
            for (int i = 0; i < 4; i++)
            {
                if (koord[i] % 20 == 1)
                {
                    return false;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                koord[i] = koord[i] - 1;
            }
            return true;
        }
    }

    class El1 : figura
    {
        public El1()
        {
            koord[0] = 10;
            koord[1] = 30;
            koord[2] = 50;
            koord[3] = 51;
        }
    }           //Zavrseno!

    class El2 : figura
    {
        public El2()
        {
            koord[0] = 12;
            koord[1] = 30;
            koord[2] = 31;
            koord[3] = 32;
        }
    }           //Zavrseno!

    class El3 : figura
    {
        public El3()
        {
            koord[0] = 10;
            koord[1] = 11;
            koord[2] = 31;
            koord[3] = 51;
        }
    }           //Zavrseno!

    class El4 : figura
    {
        public El4()
        {
            koord[0] = 10;
            koord[1] = 11;
            koord[2] = 12;
            koord[3] = 30;
        }
    }           //Zavrseno!

    class Cetvorka1 : figura
    {
        public Cetvorka1()
        {
            koord[0] = 10;
            koord[1] = 30;
            koord[2] = 31;
            koord[3] = 51;
        }
    }     //Zavrseno!

    class Cetvorka2 : figura
    {
        public Cetvorka2()
        {
            koord[0] = 11;
            koord[1] = 12;
            koord[2] = 30;
            koord[3] = 31;
        }
    }     //Zavrseno!

    class Kvadrat : figura
    {
        public Kvadrat()
        {
            koord[0] = 10;
            koord[1] = 11;
            koord[2] = 30;
            koord[3] = 31;
        }
    }       //Zavrseno!

    class Linija1 : figura
    {
        public Linija1()
        {
            koord[0] = 9;
            koord[1] = 10;
            koord[2] = 11;
            koord[3] = 12;
        }
    }       //Zavrseno!

    class Linija2 : figura
    {
        public Linija2()
        {
            koord[0] = 10;
            koord[1] = 30;
            koord[2] = 50;
            koord[3] = 70;
        }
    }       //Zavrseno!

    class T1 : figura
    {
        public T1()
        {
            koord[0] = 10;
            koord[1] = 29;
            koord[2] = 30;
            koord[3] = 31;
        }
    }            //Zavrseno!

    class T2 : figura
    {
        public T2()
        {
            koord[0] = 11;
            koord[1] = 30;
            koord[2] = 31;
            koord[3] = 51;
        }
    }            //Zavrseno!

    class T3 : figura
    {
        public T3()
        {
            koord[0] = 9;
            koord[1] = 10;
            koord[2] = 11;
            koord[3] = 30;
        }
    }            //Zavrseno!

    class T4 : figura
    {
        public T4()
        {
            koord[0] = 10;
            koord[1] = 30;
            koord[2] = 31;
            koord[3] = 50;
        }
    }            //Zavrseno!

    class El5 : figura
    {
        public El5()
        {
            koord[0] = 11;
            koord[1] = 31;
            koord[2] = 50;
            koord[3] = 51;
        }
    }           //Zavrseno!

    class El6 : figura
    {
        public El6()
        {
            koord[0] = 10;
            koord[1] = 30;
            koord[2] = 31;
            koord[3] = 32;
        }
    }           //Zavrseno!

    class El7 : figura
    {
        public El7()
        {
            koord[0] = 10;
            koord[1] = 11;
            koord[2] = 30;
            koord[3] = 50;
        }
    }           //Zavrseno!

    class El8 : figura
    {
        public El8()
        {
            koord[0] = 10;
            koord[1] = 11;
            koord[2] = 12;
            koord[3] = 32;
        }
    }           //Zavrseno!

    class Cetvorka3 : figura
    {
        public Cetvorka3()
        {
            koord[0] = 11;
            koord[1] = 30;
            koord[2] = 31;
            koord[3] = 50;
        }
    }     //Zavrseno!

    class Cetvorka4 : figura
    {
        public Cetvorka4()
        {
            koord[0] = 10;
            koord[1] = 11;
            koord[2] = 31;
            koord[3] = 32;
        }
    }     //Zavrseno!
}
