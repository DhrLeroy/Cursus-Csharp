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

        public Luchthaven(string naam, string afkorting, string land, int hoogteZeeniveau)
        {
            Naam = naam;
            Afkorting = afkorting;
            Land = land;
            HoogteZeeniveau = hoogteZeeniveau;
        }

        public Luchthaven()
        {
        }

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

        public Passagier(string naam, string voornaam, string emailadres, int rijNummer, string stoelNummer, string soortTicket)
        {
            Naam = naam;
            Voornaam = voornaam;
            Emailadres = emailadres;
            RijNummer = rijNummer;
            StoelNummer = stoelNummer;
            SoortTicket = soortTicket;
        }

        public Passagier()
        {
            
        }
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

        public Vlucht()
        {
            
        }

        public Vlucht(string naam, string code, string maatschappij, Luchthaven van, Luchthaven naar, DateTime datum, TimeSpan duurtijd, List<Passagier> passagiers)
        {
            Naam = naam;
            Code = code;
            Maatschappij = maatschappij;
            Van = van;
            Naar = naar;
            Datum = datum;
            Duurtijd = duurtijd;
            Passagiers = passagiers;
        }
    }
}
