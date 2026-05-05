using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toets_LINQ_1
{
    public class Sateliet
    {
        public string Naam { get; set; }
        public string Type { get; set; } // Maan of Kunstmatig
        public double Diameter { get; set; } // km
        public double Massa { get; set; } // 10^20 kg
        public double Omlooptijd { get; set; } // dagen rond planeet
        public double AfstandTotPlaneet { get; set; } // km
        public bool IsBewoonbaar { get; set; }
        public bool HeeftAtmosfeer { get; set; }
        public double TemperatuurGemiddeld { get; set; } // °C
        public string Missie { get; set; } // bv. "Onderzoek", "Communicatie"
        public int LanceerJaar { get; set; } // voor kunstmatige satellieten

        public Sateliet(string naam, string type, double diameter, double massa,
            double omlooptijd, double afstandTotPlaneet, bool isBewoonbaar,
            bool heeftAtmosfeer, double temperatuurGemiddeld,
            string missie, int lanceerJaar)
        {
            Naam = naam;
            Type = type;
            Diameter = diameter;
            Massa = massa;
            Omlooptijd = omlooptijd;
            AfstandTotPlaneet = afstandTotPlaneet;
            IsBewoonbaar = isBewoonbaar;
            HeeftAtmosfeer = heeftAtmosfeer;
            TemperatuurGemiddeld = temperatuurGemiddeld;
            Missie = missie;
            LanceerJaar = lanceerJaar;
        }
    }
}
