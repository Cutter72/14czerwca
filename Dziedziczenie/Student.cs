using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;
        List<Ocena> oceny = new List<Ocena>();

        public Student(string imie_, string nazwisko_, string dataUrodzenia_, int rok_, int grupa_, int nrIndeksu_) : base(imie_, nazwisko_, dataUrodzenia_) {
            this.rok = rok_;
            this.grupa = grupa_;
            this.nrIndeksu = nrIndeksu_;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Dodatkowe informacje: rok {this.rok}, grupa {this.grupa}, nr indeksu {this.nrIndeksu}");

            Console.WriteLine($"Oceny studenta: ");
            foreach (Ocena ocena in oceny)
            {
                ocena.WypiszInfo();
            }
        }

        #region metody obsługujące oceny

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            Ocena ocena = new Ocena(nazwaPrzedmiotu, data, wartosc);
            oceny.Add(ocena);
        }

        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc) {

            for (int i = 0; i < oceny.Count;)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu && o.Data == data && o.Wartosc == wartosc)
                {
                    oceny.RemoveAt(i);
                }

                else
                {

                    ++i;
                } 
            }
        }

        public void WypiszOceny() {
            // TODO 28 czerwca
        }

        public void WypiszOceny(string nazwaPrzedmiotu) {
            // TODO 28 czerwca
        }

        public void UsunOceny() {
            // TODO 28 czerwca
        }

        public void UsunOceny(string nazwaPrzedmiotu) {
            // TODO 28 czerwca
        }
        #endregion
    }
}
