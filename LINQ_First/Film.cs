using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_First
{
    internal class Film
    {
        public string Titel { get; set; }
        public int Duurtijd_min { get; set; }

        public Film(string titel, int duurtijd_min)
        {
            Titel = titel;
            Duurtijd_min = duurtijd_min;
        }
    }
}
