using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening7InleidingFilm___Oplossing
{
    internal class Film
    {
        public string Titel { get; set; }
        public string Genre { get; set; }
        public int Duurtijd_in_minuten { get; set; }
        public double Rating_op_10 { get; set; }

        public Film(string titel, string genre, int duurtijd_in_minuten, double rating_op_10)
        {
            Titel = titel;
            Genre = genre;
            Duurtijd_in_minuten = duurtijd_in_minuten;
            Rating_op_10 = rating_op_10;
        }
    }
}
