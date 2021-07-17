using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium_3_zad_2
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        List<Autor> autorzy = new List<Autor>();


        public int LiczbaStron 
        { get 
            { 
                return liczbaStron; 
            } 
        }

        public Ksiazka()
        {
            liczbaStron = 0;
        }
        public Ksiazka(string tytul_, int id_, string wydawnictwo_, int dataWydania_, int liczbaStron_) : base(tytul_, id_, wydawnictwo_, dataWydania_)
        {
            liczbaStron = liczbaStron_;
        }

        public void DodajAutora(Autor a)
        {
            autorzy.Add(a);
        }
        public override void WypiszInfo()
        {
            foreach (Autor aut in autorzy)
                Console.WriteLine(aut.Imie + ", " + aut.Nazwisko + ", ");
            
            Console.WriteLine("Tytuł: " + tytul);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Wydawnictwo: " + wydawnictwo);
            Console.WriteLine("Data wydania: " + dataWydania);
            Console.WriteLine("Liczba stron: " + liczbaStron);
            Console.WriteLine();

        }
    }
}
