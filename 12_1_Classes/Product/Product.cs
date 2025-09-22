using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_Classes.Product
{
    public abstract class Product
    {
        public int Id { get; set; }
        public float? Prijs { get; set; }
        public string Naam { get; set; }
        
    }
}
