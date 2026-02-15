using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_VoorbeeldCursus
{
    internal class Dier
    {
        public string Naam { get; set; }
        public string Kleur { get; set; }
        public string Klasse { get; set; }
        public bool Is_herbivoor { get; set; }
        public int Aantal_in_zoo { get; set; }
        public bool Kan_vliegen { get; set; }

        public Dier(string naam, string kleur, string klasse, bool is_herbivoor, int aantal_in_zoo, bool kan_vliegen)
        {
            Naam = naam;
            Kleur = kleur;
            Klasse = klasse;
            Is_herbivoor = is_herbivoor;
            Aantal_in_zoo = aantal_in_zoo;
            Kan_vliegen = kan_vliegen;
        }
    }
}
