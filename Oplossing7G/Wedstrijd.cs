using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing7G
{
    public class Wedstrijd
    {
        public string Sponsor { get; set; }
        public List<Speler> Spelers { get; set; }
        public int Gemaakte_doelpunten { get; set; }
        public int Geïncasseerde_doelpunten { get; set; }

        public Wedstrijd(string sponser, List<Speler> spelers)
        {
            Sponsor = sponser;
            Spelers = spelers.ToList();
        }

        public void VerhoogScore(bool eigenPloeg)
        {
            if (eigenPloeg)
                Gemaakte_doelpunten++;
            else
                Geïncasseerde_doelpunten++;
        }

        public void ToonUitslag()
        {
            Console.WriteLine($"Wedstrijd gesponsord door: {Sponsor}");
            Console.WriteLine($"Score: {Gemaakte_doelpunten} - {Geïncasseerde_doelpunten}");
            Console.WriteLine("Deelnemende spelers:");
            foreach (var speler in Spelers)
            {
                Console.WriteLine($"{speler.Voornaam} {speler.Naam} - Positie: {speler.Positie}");
            }
        }
    }
}
