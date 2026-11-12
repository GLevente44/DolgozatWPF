using System;
using System.Collections.Generic;
using System.Text;

namespace DolgozatWPF
{
    public class Dolgozo
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public int Pontszam { get; set; }

        public Dolgozo(string nev, int eletkor, int pontszam)
        {
            Nev = nev;
            Eletkor = eletkor;
            Pontszam = pontszam;
        }
    }
}
