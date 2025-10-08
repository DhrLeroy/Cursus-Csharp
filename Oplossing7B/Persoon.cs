using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing7B
{
    public class Persoon
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public int Geboortejaar { get; set; }
        public float Lengte { get; set; }
        public float Gewicht { get; set; }
        public bool IsMannelijk { get; set; }

        public Persoon(string naam, string voornaam, int geboortejaar, float lengte, float gewicht, bool isMannelijk)
        {
            Naam = naam;
            Voornaam = voornaam;
            Geboortejaar = geboortejaar;
            Lengte = lengte;
            Gewicht = gewicht;
            IsMannelijk = isMannelijk;
        }

        public void ToonInitialen()
        {
            Console.WriteLine($"{Voornaam.Substring(0,1).ToUpper()}. {Naam.Substring(0,1).ToUpper()}.");
        }

        public int BerekenLeeftijd(int jaartal)
        {
            return jaartal - Geboortejaar;
        }

        public float BerekenBMI()
        {
            return Gewicht / (Lengte * Lengte);
        }

    }
}
