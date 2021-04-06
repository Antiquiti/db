using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych
{
    class Car
    {
        public int id_samochod { get; set; }
        public string model { get; set; }
        public string marka { get; set; }
        public string kolor { get; set; }

        public Car(int id_samochod,string model, string marka, string kolor)
        {
            this.id_samochod = id_samochod;
            this.model = model;
            this.marka = marka;
            this.kolor = kolor;
        }

        public override string ToString()
        {
            return String.Format(model + " " + marka + "  Kolor: " + kolor);
        }
    }
}
