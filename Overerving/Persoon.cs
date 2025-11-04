using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    public class Persoon
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public int Geboortejaar { get; set; }
        public bool Mannelijk { get; set; }

        public string Initialen()
        {
            return $"{Voornaam.Substring(0, 1).ToUpper()}. {Naam.Substring(0, 1).ToUpper()}.";
        }

        public int Leeftijd()
        {
            return 2026 - Geboortejaar;
        }
    }
    public class Leerling : Persoon
    {
        public string Klas { get; set; }
        public double Percentage { get; set; }
    }

    public class Medewerker : Persoon
    {

        public double Salaris { get; set; }
    }

    public class Leerkracht : Medewerker
    {
        public string Vak { get; set; }

    }

    public class Secretariaatsmedewerker : Medewerker
    {
        public string Printcode { get; set; }
    }
}
