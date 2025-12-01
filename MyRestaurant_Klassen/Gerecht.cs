using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant_Klassen
{
    public class Gerecht
    {
        public int GerechtId { get; set; }
        public string Naam { get; set; }
        public float Prijs { get; set; }
        public List<Menu> InMenus { get; set; }
        public List<Ingredient> Ingredienten { get; set; }


        public Gerecht()
        {
            
        }
        public Gerecht(string naam, float prijs, params Ingredient[] ingredienten)
        {
            Naam = naam;
            Prijs = prijs;
            Ingredienten = ingredienten.ToList();
        }
    }
}
