using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_Classes.Product
{
    public enum Soort
    {
        Pennenzak,
        Knuffel,
        Standbeeld,
        Kledij
    }

    public class Afmeting
    {
        public float Lengte { get; set; }
        public float Breedte { get; set; }
        public float Diepte { get; set; }

        public float Volume()=>Lengte*Breedte*Diepte;
    }

    public class Merchandise : Product
    {
        public Soort Soort { get; set; }
        public float Gewicht { get; set; }
        public Afmeting Afmeting { get; set; }


    }
}
