using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toets_LINQ_1
{
    public class Planeet
    {
        public string Naam { get; set; }
        public string Type { get; set; } // Terrestrisch, Gasreus, IJsreus
        public double Diameter { get; set; } // km
        public double Massa { get; set; } // 10^24 kg
        public double Zwaartekracht { get; set; } // m/s²
        public double AfstandTotZon { get; set; } // miljoen km
        public double Omlooptijd { get; set; } // dagen rond de zon
        public double Rotatietijd { get; set; } // uren (daglengte)
        public bool HeeftLeven { get; set; }
        public bool HeeftRingen { get; set; }
        public double TemperatuurGemiddeld { get; set; } // °C
        public int AantalManen { get; set; } // optioneel (kan ook via lijst)
        public string Atmosfeer { get; set; } // bv. "Stikstof/Zuurstof"

        public List<Sateliet> Satelieten { get; set; } = new();

        public Planeet(string naam, string type, double diameter, double massa,
            double zwaartekracht, double afstandTotZon, double omlooptijd,
            double rotatietijd, bool heeftLeven, bool heeftRingen,
            double temperatuurGemiddeld, int aantalManen, string atmosfeer)
        {
            Naam = naam;
            Type = type;
            Diameter = diameter;
            Massa = massa;
            Zwaartekracht = zwaartekracht;
            AfstandTotZon = afstandTotZon;
            Omlooptijd = omlooptijd;
            Rotatietijd = rotatietijd;
            HeeftLeven = heeftLeven;
            HeeftRingen = heeftRingen;
            TemperatuurGemiddeld = temperatuurGemiddeld;
            AantalManen = aantalManen;
            Atmosfeer = atmosfeer;
        }

        public void VoegSatelietToe(Sateliet sateliet)
        {
            Satelieten.Add(sateliet);
        }
    }
}
