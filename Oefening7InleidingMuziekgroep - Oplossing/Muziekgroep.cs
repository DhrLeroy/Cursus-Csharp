using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening7InleidingMuziekgroep___Oplossing
{
    internal class Muziekgroep
    {
        public string Naam { get; set; }
        public string Genre { get; set; }
        public int Aantal_albums { get; set; }
        public int Jaar_oprichting { get; set; }

        public Muziekgroep(string naam, string genre, int aantal_albums, int jaar_oprichting)
        {
            Naam = naam;
            Genre = genre;
            Aantal_albums = aantal_albums;
            Jaar_oprichting = jaar_oprichting;
        }
    }
}
