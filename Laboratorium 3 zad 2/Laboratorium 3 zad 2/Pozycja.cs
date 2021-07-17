using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium_3_zad_2
{
    abstract class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int dataWydania;


        public string Tytul 
        { 
            get 
            { 
                return tytul; 
            } 
        }
        public int Id 
        { 
            get 
            { 
                return id; 
            } 
        }
        public string Wydawnictwo 
        { 
            get 
            { 
                return wydawnictwo; 
            } 
        }
        public int DataWydania 
        { 
            get 
            { 
                return dataWydania; 
            } 
        }

        public Pozycja()
        {
            tytul = "nieznany";
            id = 0;
            wydawnictwo = "nieznane";
            dataWydania = 0;
        }

        public Pozycja(string tytul_, int id_, string wydawnictwo_, int dataWydania_)
        {
            tytul = tytul_;
            id = id_;
            wydawnictwo = wydawnictwo_;
            dataWydania = dataWydania_;

        }
        public abstract void WypiszInfo();
    }
}
