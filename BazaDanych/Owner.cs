using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych
{
    class Owner
    {
        public int id_wlasciciel { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int id_samochod { get; set; }

        public Owner(int id_wlasciciel, string imie, string nazwisko, int id_samochod)
        {
            this.id_wlasciciel = id_wlasciciel;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.id_samochod = id_samochod;
        }

        public override string ToString()
        {
            return imie + " " + nazwisko;
        }
    }
}
