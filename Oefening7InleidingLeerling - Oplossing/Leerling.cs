using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening7InleidingLeerling___Oplossing
{
    internal class Leerling
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public string Klas { get; set; }

        public Leerling(string voornaam, string naam, int leeftijd, string klas)
        {
            Voornaam = voornaam;
            Naam = naam;
            Leeftijd = leeftijd;
            Klas = klas;
        }
    }
}
