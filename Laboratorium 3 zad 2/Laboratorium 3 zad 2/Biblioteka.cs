using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium_3_zad_2
{
    class Biblioteka
    {
        public string adres;
        List<Bibliotekarz> bibliotekarze = new List<Bibliotekarz>();
        List<Katalog> katalogi = new List<Katalog>();

        public string Adres 
        { 
            get 
            { 
                return adres; 
            } 
        }

        public Biblioteka()
        {
            adres = "nieznany";
        }
        public Biblioteka(string adres_)
        {
            adres = adres_;
        }
        public void DodajBibliotekarza(Bibliotekarz bibliotekarz)
        {
            bibliotekarze.Add(bibliotekarz);
        }
        public void WypiszBibliotekarzy()
        {
            Console.WriteLine("Wszyscy Bibliotekarze to: ");
            Console.WriteLine();

            foreach (Bibliotekarz bibliotekarz in bibliotekarze)
            {
                Console.WriteLine("Imię: " + bibliotekarz.Imie);
                Console.WriteLine("Nazwisko: " + bibliotekarz.Nazwisko);
                Console.WriteLine("Data Zatrudnienia: " + bibliotekarz.DataZatrudnienia);
                Console.WriteLine("Wynagrodzenie: " + bibliotekarz.Wynagrodzenie);
                Console.WriteLine();
            }
                
          
        }
        public void DodajKatalog(Katalog katalog)
        {
            katalogi.Add(katalog);
        }
        public void DodajPozycje(Pozycja poz, string dzialTematyczny_)
        {
            foreach (Katalog katalog in katalogi)
            {
                if (katalog.DzialTematyczny == dzialTematyczny_)
                    katalog.DodajPozycje(poz);
            }

        }
        public void ZnajdzPozycjePoTytule(string tytul)
        {
            foreach (Katalog kat in katalogi)
                kat.ZnajdzPozycjePoTytule(tytul);
        }
        public void ZnajdzPozycjePoId(int id)
        {
            foreach (Katalog kat in katalogi)
                kat.ZnajdzPozycjePoId(id);
        }
        public void WypiszWszystkiePozycje()
        {
            Console.WriteLine("Zasoby Biblioteki");
            Console.WriteLine();
            
            foreach (Katalog kat in katalogi)
                kat.WypiszWszystkiePozycje();
        }
    }
}
