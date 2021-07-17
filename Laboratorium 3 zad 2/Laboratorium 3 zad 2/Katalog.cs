using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium_3_zad_2
{
    class Katalog
    {
        private string dzialTematyczny;
        private List<Pozycja> pozycje = new List<Pozycja>();


        public string DzialTematyczny 
        { 
            get 
            { 
                return dzialTematyczny; 
            } 
        }

        public Katalog()
        {
            dzialTematyczny = "nieznany";
        }
        public Katalog(string dzialTematyczny_)
        {
            dzialTematyczny = dzialTematyczny_;
        }

        public void DodajPozycje(Pozycja p)
        {
            pozycje.Add(p);
        }

        public void ZnajdzPozycjePoTytule(string tytul)
        {
            bool jest = false;
            foreach (Pozycja p in pozycje)
            {
                if (p.Tytul == tytul)
                {
                    p.WypiszInfo();
                    jest = true;
                }
            }
            if (jest == false) Console.WriteLine("brak tytulu");

        }
        public void ZnajdzPozycjePoId(int id)
        {
            bool jest = false;
            foreach (Pozycja p in pozycje)
            {
                if (p.Id == id)
                {
                    p.WypiszInfo();
                    jest = true;
                }
            }
            if (jest == false) Console.WriteLine("brak tytulu");
        }
        public void WypiszWszystkiePozycje()

        {
            Console.WriteLine("Zawartość Katalogu: ");
            Console.WriteLine();

            foreach (Pozycja p in pozycje)
                p.WypiszInfo();
        }
    }
}
