using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing7G
{
    public class Speler
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string Positie { get; set; }

        public Speler(string voornaam, string naam, string positie)
        {
            Voornaam = voornaam;
            Naam = naam;
            Positie = positie;
        }
    }
}
