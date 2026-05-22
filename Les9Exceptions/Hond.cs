using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les9Exceptions
{
    public class Hond
    {
        public string Naam { get; set; }
        public int AantalPoten { get; set; }

        public Hond(string naam, int aantalPoten)
        {
            Naam = naam;
            AantalPoten = aantalPoten;
        }
    }
}
