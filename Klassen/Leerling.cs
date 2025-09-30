using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    internal class Leerling
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public int Leeftijd { get; set; }
        public bool Mannelijk { get; set; }

        public Leerling()
        {
        }

        public Leerling(string naam, string voornaam, int leeftijd)
        {
            Naam = naam;
            Voornaam = voornaam;
            Leeftijd = leeftijd;
        }
    }
}
