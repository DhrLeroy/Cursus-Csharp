using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films.Classes
{
    public class Film
    {
        public FilmReeks Reeks { get; set; }
        public string Regisseur { get; set; }
        public string Titel { get; set; }
        public int Releasejaar { get; set; }
        public List<Rol> Rollen { get; set; }

        public Film(FilmReeks reeks, string naam, string regisseur, int release, params Rol[] rollen)
        {
            Reeks = reeks;
            Titel = naam;
            Regisseur = regisseur;
            Releasejaar = release;
            Rollen = rollen.ToList();
        }

        public override string ToString() => $"{(string.IsNullOrEmpty(Reeks?.Naam) ? "" : $"{Reeks.Naam}: ")}{Titel} ({Releasejaar})";
    }
}
