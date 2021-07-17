using System;

namespace Laboratorium_3_zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ksiazka ksiazkaPierwsza = new Ksiazka("Cyfrowa Twierdza", 1, "St.Martin's Press",1998, 721);
            Ksiazka ksiazkaDruga = new Ksiazka("Anioły i demony", 2, "Doubleday",2000, 689);
            Ksiazka ksiazkaTrzecia = new Ksiazka("Zwodniczy punkt", 3,"Simon & Shuster",2001, 759);
            Ksiazka ksiazkaCzwarta = new Ksiazka("Kod Leonarda da Vinci", 4, "Doubleday", 2003, 859);
            Ksiazka ksiazkaPiata = new Ksiazka("Zaginiony symbol", 5, "Random House",2009, 699);

            ksiazkaPierwsza.WypiszInfo();
            ksiazkaDruga.WypiszInfo();
            ksiazkaTrzecia.WypiszInfo();
            ksiazkaCzwarta.WypiszInfo();
            ksiazkaPiata.WypiszInfo();

            Czasopismo czasopismoPierwsze = new Czasopismo("Przegląd sportowy", 1, "Ringier Axel Springer Polska", 2021, 30);
            Czasopismo czasopismoDrugie = new Czasopismo("Sport", 2, "Gremi Media SA",2013, 25);
            Czasopismo czasopismoTrzecie = new Czasopismo("Tylko Piłka", 3, "Tylko Piłka SA", 2020, 68);

            czasopismoPierwsze.WypiszInfo();
            czasopismoDrugie.WypiszInfo();
            czasopismoTrzecie.WypiszInfo();

            Autor autorPierwszy = new Autor("Dan", "Brown", "Amerykanin");
            Autor autorDrugi = new Autor("Krzysztof", "Stanowski", "Polak");
            Autor autorTrzeci = new Autor("Stefan", "King", "Amerykanski");

            ksiazkaPierwsza.DodajAutora(autorPierwszy);
            ksiazkaTrzecia.DodajAutora(autorDrugi);
            ksiazkaPiata.DodajAutora(autorTrzeci);

            ksiazkaPierwsza.WypiszInfo();
            ksiazkaTrzecia.WypiszInfo();

            Katalog katalogPierwszy = new Katalog("Sportowy");
            katalogPierwszy.DodajPozycje(czasopismoPierwsze);
            katalogPierwszy.DodajPozycje(czasopismoDrugie);
            katalogPierwszy.DodajPozycje(czasopismoTrzecie);
            katalogPierwszy.WypiszWszystkiePozycje();

            Katalog katalogDrugi = new Katalog("Thrillery");
            katalogDrugi.DodajPozycje(ksiazkaPierwsza);
            katalogDrugi.DodajPozycje(ksiazkaDruga);
            katalogDrugi.DodajPozycje(ksiazkaTrzecia);
            katalogDrugi.DodajPozycje(ksiazkaCzwarta);
            katalogDrugi.DodajPozycje(ksiazkaPiata);
            
            katalogDrugi.WypiszWszystkiePozycje();

            Biblioteka bibliotekaPierwsza = new Biblioteka("Kartuzy");
            bibliotekaPierwsza.DodajKatalog(katalogPierwszy);
            bibliotekaPierwsza.DodajKatalog(katalogDrugi);

            bibliotekaPierwsza.WypiszWszystkiePozycje();

            Bibliotekarz bibliotekarzPierwszy = new Bibliotekarz("Mateusz", "Bór", "13.11.2021", 2300.00);
            Bibliotekarz bibliotekarzDrugi = new Bibliotekarz("Janusz", "Panek", "13.01.2011", 2600.00);
            Bibliotekarz bibliotekarzTrzeci = new Bibliotekarz("Ewa", "Wik", "12.03.2001", 3300.00);

            bibliotekaPierwsza.DodajBibliotekarza(bibliotekarzPierwszy);
            bibliotekaPierwsza.DodajBibliotekarza(bibliotekarzDrugi);
            bibliotekaPierwsza.DodajBibliotekarza(bibliotekarzTrzeci);

            bibliotekaPierwsza.WypiszBibliotekarzy();

            
        }
    }
}
