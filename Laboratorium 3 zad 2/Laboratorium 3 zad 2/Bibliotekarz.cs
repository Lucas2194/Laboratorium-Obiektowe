using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium_3_zad_2
{
    class Bibliotekarz : Osoba
    {
        private string dataZatrudnienia;
        private double wynagrodzenie;

        public string DataZatrudnienia 
        { 
            get 
            { 
                return dataZatrudnienia; 
            } 
        }
        public double Wynagrodzenie 
        { 
            get 
            { 
                return wynagrodzenie; 
            } 
        }


        public Bibliotekarz() : base()
        {
            dataZatrudnienia = "nienzane";
            wynagrodzenie = 0;
        }
        public Bibliotekarz(string imie_, string nazwisko_, string dataZatrudnienia_, double wynagrodzenie_) : base(imie_, nazwisko_)
        {
            dataZatrudnienia = dataZatrudnienia_;
            wynagrodzenie = wynagrodzenie_;
        }
    }
}
