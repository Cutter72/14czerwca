using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Ocena
    {
        private string nazwaPrzedmiotu;

        public string NazwaPrzedmiotu
        {
            get { return nazwaPrzedmiotu; }
            set { nazwaPrzedmiotu = value; }
        }

        private string data;

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private double wartosc;

        public double Wartosc
        {
            get { return wartosc; }
            set { wartosc = value; }
        }

        public Ocena(string nazwaPrzedmiotu_, string data_, double wartosc_)
        {
            this.nazwaPrzedmiotu = nazwaPrzedmiotu_;
            this.data = data_;
            this.wartosc = wartosc_;
        }

        public void WypiszInfo() {
            Console.WriteLine($"Informacje o ocenie: {this.nazwaPrzedmiotu}, {this.data}, {this.wartosc} ");
        }
    }
}
