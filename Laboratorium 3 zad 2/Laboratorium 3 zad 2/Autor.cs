using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium_3_zad_2
{
    class Autor : Osoba
    {
        public string narodowosc;

        public string Narodowosc 
        { 
            get 
            { 
                return narodowosc; 
            } 
        }


        public Autor() : base()
        {
            narodowosc = "nieznane";
        }
        public Autor(string imie_, string nazwisko_, string narodowosc_) : base(imie_, nazwisko_)
        {
            narodowosc = narodowosc_;
        }
    }
}
