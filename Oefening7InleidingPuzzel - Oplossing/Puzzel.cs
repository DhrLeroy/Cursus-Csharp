using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening7InleidingPuzzel___Oplossing
{
    internal class Puzzel
    {
        public string Fabrikant { get; set; }
        public string Beschrijving { get; set; }
        public int Aantal_stukjes { get; set; }
        public double Prijs { get; set; }

        public Puzzel(string fabrikant, string beschrijving, int aantal_stukjes, double prijs)
        {
            Fabrikant = fabrikant;
            Beschrijving = beschrijving;
            Aantal_stukjes = aantal_stukjes;
            Prijs = prijs;
        }
    }
}
