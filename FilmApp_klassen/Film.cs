using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApp_klassen
{
    public class Film
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public int Duurtijd_minuten { get; set; }
        public bool LiveAction { get; set; }
    }
}
