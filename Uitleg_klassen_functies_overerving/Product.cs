using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitleg_klassen_functies_overerving
{
    public class Product
    {
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public int Hoeveelheid { get; set; }
        public string Eenheid { get; set; }
        public double Gewicht_kg { get; set; }

        public Product(string naam, double prijs, int hoeveelheid, string eenheid, double gewicht_kg)
        {
            Naam = naam;
            Prijs = prijs;
            Hoeveelheid = hoeveelheid;
            Eenheid = eenheid;
            Gewicht_kg = gewicht_kg;
        }

        public double PrijsPerKg()
        {
            return Prijs / Gewicht_kg;
        }
    }

    public class Variatie : Product
    {
        public Variatie(string naam, double prijs, int hoeveelheid, string eenheid, double gewicht_kg, string inhoud) : base(naam, prijs, hoeveelheid, eenheid, gewicht_kg)
        {
            Inhoud = inhoud;
        }
        public string Inhoud { get; set; }


    }
}
