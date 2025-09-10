using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling_Examen_2_5ICW___2024_2025___Oefening_3
{
    public class Persoon
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }

        public Persoon(string voornaam, string naam, int geboortejaar, int geboortemaand, int geboorteday)
        {
            Voornaam = voornaam;
            Naam = naam;
            Geboortedatum = new DateTime(geboortejaar, geboortemaand, geboorteday);
        }

        public int BerekenLeeftijd()
        {
            int leeftijd = DateTime.Today.Year - Geboortedatum.Year;
            DateTime verjaardagDitJaar = Geboortedatum.AddYears(leeftijd);
            if (verjaardagDitJaar > DateTime.Today)
                leeftijd--;
            return leeftijd;
        }
    }
}
