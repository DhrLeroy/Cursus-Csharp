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
        public int Geboortejaar { get; set; }
        public string Soort { get; private set; }
        public Medewerker Favoriete_verzorger { get; set; }

        public Dier(string naam, string soort)
        {
            Naam = naam;
            Soort = soort;
        }

        public int BerekenLeeftijd(int jaartal)
        {
            jaartal = 0;
            int leeftijd = jaartal - Geboortejaar;
            if (leeftijd < 0)
                return 0;
            return leeftijd;
        }

        public void PrintLabel()
        {
            Console.WriteLine($"{Naam} ({Soort})");
        }

        public string GeefLabel()
        {
            Console.WriteLine($"{Naam} ({Soort})");
            return $"{Naam} ({Soort})";
        }
    }
}
