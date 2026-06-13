using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Vluchten
{
    public class Luchthaven
    {
        public string Naam { get; set; }
        public string Afkorting { get; set; }
        public string Land { get; set; }
        public int HoogteZeeniveau { get; set; } // meter

        public override string ToString()
        {
            return $"{Afkorting} - {Naam}";
        }
    }

    public class Passagier
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Emailadres { get; set; }
        public int RijNummer { get; set; }
        public string StoelNummer { get; set; }
        public string SoortTicket { get; set; }
    }

    public class Vlucht
    {
        public string Naam { get; set; }
        public string Code { get; set; }
        public string Maatschappij { get; set; }

        public Luchthaven Van { get; set; }
        public Luchthaven Naar { get; set; }

        public DateTime Datum { get; set; }
        public TimeSpan Duurtijd { get; set; }

        public List<Passagier> Passagiers { get; set; } = new();
    }
}
