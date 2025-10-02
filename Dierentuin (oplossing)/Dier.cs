using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin__oplossing_
{
    public class Dier
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public string Soort { get; private set; }
        public Medewerker Favoriete_verzorger { get; set; }

        public Dier(string naam, string soort)
        {
            Naam = naam;
            Soort = soort;
        }
    }
}
