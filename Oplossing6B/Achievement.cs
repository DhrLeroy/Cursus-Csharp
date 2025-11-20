using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Games.Klassen
{
    public class Achievement
    {
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public int Moeilijkheidsgraad { get; set; } // 1 (makkelijk) t.e.m. 5 (zeer moeilijk)
        public bool IsGeheim { get; set; }

        public Achievement(string naam, string beschrijving, int moeilijkheidsgraad, bool isGeheim)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            Moeilijkheidsgraad = moeilijkheidsgraad;
            IsGeheim = isGeheim;
        }

        public override string? ToString()
        {
            return $"{Naam} ({Moeilijkheidsgraad})";
        }
    }
}
