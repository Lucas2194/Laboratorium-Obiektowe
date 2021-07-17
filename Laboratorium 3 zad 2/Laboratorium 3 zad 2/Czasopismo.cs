using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium_3_zad_2
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public int Numer 
        { 
            get 
            { 
                return numer; 
            } 
        }

        public Czasopismo() : base()
        {
            numer = 0;
        }
        public Czasopismo(string tytul_, int id_, string wydawnictwo_, int dataWydania_, int numer_) : base(tytul_, id_, wydawnictwo_, dataWydania_)
        {
            numer = numer_;
        }

        public override void WypiszInfo()
        {
            

            Console.WriteLine("Tytuł: " + tytul);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Wydawnictwo: " + wydawnictwo);
            Console.WriteLine("Data wydania: " + dataWydania);
            Console.WriteLine("Numer: " + numer);
            Console.WriteLine();
        }
    }
}
