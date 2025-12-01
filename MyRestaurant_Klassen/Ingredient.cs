using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant_Klassen
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Naam { get; set; }
        public float PrijsPerKg { get; set; }
        public List<Gerecht> InGerechten { get; set; }

        public Ingredient()
        {
            
        }

        public Ingredient(string naam, float prijsPerKg)
        {
            Naam = naam;
            PrijsPerKg = prijsPerKg;
        }
    }
}
