using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_6___LINQ
{
    internal class Film
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public float Rating { get; set; }
        public TimeSpan Duurtijd { get; set; }
        public string Categorie { get; set; }

        public Film(int id, string titel, float rating, TimeSpan duurtijd, string categorie)
        {
            Id = id;
            Titel = titel;
            Rating = rating;
            Duurtijd = duurtijd;
            Categorie = categorie;
        }
    }
}
