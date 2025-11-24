using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films.Classes
{
    public class Rol
    {
        public List<Film> Films { get; set; } // A role exists in multiple films
        public string Naam { get; set; }
        public List<Acteur> Acteurs { get; set; }

        public Rol(string naam, params Acteur[] acteurs)
        {
            Films = new List<Film>();
            Naam = naam;
            Acteurs = acteurs.ToList();
            foreach (var acteur in Acteurs)
            {
                acteur.Rollen.Add(this);
            }
        }

        public void AddFilm(Film film)
        {
            Films.Add(film);
        }
    }
}
