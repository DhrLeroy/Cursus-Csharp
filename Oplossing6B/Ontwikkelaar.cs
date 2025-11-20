using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Games.Klassen
{
    public class Ontwikkelaar
    {
        public string Naam { get; set; }
        public List<Game> Games { get; set; } = new();

        public Ontwikkelaar(string naam)
        {
            Naam = naam;
        }
    }
}
