using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    public class Dier
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public string Soort { get; set; }
    }

    public class Hond : Dier
    {
        public string Favoriet_speeltjes { get; set; }
    }
    public class Kat : Dier
    {
        public bool Gesteriliseerd { get; set; }
    }
}
