using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Databanken
{
    public class Auteur
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public List<Boek> Boeken { get; set; } = new List<Boek>();

    }
    public class Boek
    {
        public int Id { get; set; }
        public Auteur Auteur { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public int Aantal_paginas { get; set; }
    }
}
