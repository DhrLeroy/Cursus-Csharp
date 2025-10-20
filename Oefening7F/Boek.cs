using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening7F
{
    public class Boek
    {
        public string Titel { get; set; } = "";
        public string Auteur { get; set; } = "";
        public int Aantal_paginas { get; set; }
        public string Genre { get; set; }
        public bool Uitgeleend { get; set; } = false;

        public Boek(string titel, string auteur, int aantal_paginas, string genre)
        {
            Titel = titel;
            Auteur = auteur;
            Aantal_paginas = aantal_paginas;
            Genre = genre;
        }
    }
}
