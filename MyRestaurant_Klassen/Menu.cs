using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant_Klassen
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string Naam { get; set; }
        public float Prijs { get; set; }


        public Menu()
        {
            
        }

        public override string? ToString()
        {
            return $"{Naam}: {Prijs} euro (i.p.v. {GeefTotaalprijs(} euro)";
        }

        public float GeefTotaalprijs()
        {
            return Gerechten.Sum(g => g.Prijs);
        }
    }
}
