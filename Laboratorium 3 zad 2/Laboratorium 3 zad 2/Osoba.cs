using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium_3_zad_2
{
    class Osoba
    {
        protected string imie, nazwisko;

        public string Imie 
        { 
            get 
            { 
                return imie; 
            } 
        }
        public string Nazwisko 
        { 
            get 
            { 
                return nazwisko; 
            } 
        }

        public Osoba()
        {
            imie = "nieznane";
            nazwisko = "nieznane";
        }

        public Osoba(string imie_, string nazwisko_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
        }
    }
}
