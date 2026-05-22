using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing9C
{
    internal class Pokémon
    {
        public string Naam { get; set; }
        public string Type { get; set; }
        public int HP { get; set; }

        public Pokémon(string naam, string type, int hP)
        {
            Naam = naam;
            Type = type;
            HP = hP;
        }
    }
}
