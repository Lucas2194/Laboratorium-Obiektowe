using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium_3_zad_2
{
    interface IZarzadzaniePozycjami
    {
        public Pozycja ZnajdzPozycjePoTytule(string tytul);
        public Pozycja ZnajdzPozycjePoId(int id);
        public void WypiszWszystkiePozycje();
    }
}
