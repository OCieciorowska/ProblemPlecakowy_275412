using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Przedmiot
    {
        public int Indeks { get; set; }
        public int Waga { get; set; }
        public int Wartosc { get; set; }
        public Przedmiot(int indeks, int waga, int wartosc)
        {
            Indeks = indeks;
            Waga = waga;
            Wartosc = wartosc;
        }
    }


}
