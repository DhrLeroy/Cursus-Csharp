using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitleg_LINQ_Campus_Impuls
{
    public class Pokémon
 {
        public int Id { get; set; }
        public int Base_HP { get; set; } 
        public string Naam { get; set; }
        public string Type { get; set; }
        public double Hoogte { get; set; }
        public double Gewicht { get; set; }

         public Pokémon(string naam, int base_HP, string type, double hoogte, double gewicht)
         {
             Base_HP = base_HP;
             Naam = naam;
             Type = type;
             Hoogte = hoogte;
             Gewicht = gewicht;
         }
    }
}
