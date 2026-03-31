using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductenKlantenJson
{
    public class Klant
    {
        public string Naam { get; set; }
        public float Krediet { get; set; }
    }

    public class Product
    {
        public string Naam { get; set; }
        public float Prijs { get; set; }
    }

    public class Databestand
    {
        public List<Klant> Klanten { get; set; }
        public List<Product> Producten { get; set; }
        public string Adres { get; set; }
    }
}
