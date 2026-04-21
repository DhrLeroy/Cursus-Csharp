using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films.Classes
{
    public class Reeks
    {
        public string Naam { get; set; }
        public List<Film> Films { get; set; }

        public Reeks(string naam, List<Film> films)
        {
            Naam = naam;
            Films = films;
        }
    }
}
