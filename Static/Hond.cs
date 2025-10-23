using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Hond
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public Hond(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }

        public void BeschrijfHond()
        {
            Console.WriteLine($"{Naam} is {Leeftijd} jaar oud.");
        }

        public void Woef()
        {
            Console.WriteLine("Woef!");
        }

        public static void Blaf()
        {
            Console.WriteLine("Woef Woef!");
        }

    }
}
