using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_12___Databanken__geavanceerd_
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Naam { get; set; }
        public float Prijs { get; set; }
        public List<string> Tags { get; set; }
        public Product()
        {

        }
        public Product(string naam, float prijs, params string[] tags)
        {
            Naam = naam;
            Prijs = prijs;
            Tags = tags.ToList();
        }
        public Product(int productId, string naam, float prijs, params string[] tags)
        {
            ProductId = productId;
            Naam = naam;
            Prijs = prijs;
            Tags = tags.ToList();
        }
    }


}
