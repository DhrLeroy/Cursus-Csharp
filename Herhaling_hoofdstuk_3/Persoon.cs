using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling_hoofdstuk_3
{
    public class Persoon
    {
        public int Leeftijd { get; set; }
        public string Naam { get; set; }

        public Persoon(int leeftijd, string naam)
        {
            Leeftijd = leeftijd;
            Naam = naam;
        }
    }
    public class Klas
    {
        public string Naam { get; set; }
        public List<Persoon> Leerlingen {  get; set; }
    }
}
