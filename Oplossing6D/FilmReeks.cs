using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films.Classes
{
    public class FilmReeks
    {
        public string Naam { get; set; }
        public List<Film> Films { get; set; }

        public FilmReeks(string naam, List<Film> films)
        {
            Naam = naam;
            Films = films;
        }
    }
}
