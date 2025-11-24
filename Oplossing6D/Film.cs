using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films.Classes
{
    public class Film
    {
        public Reeks Reeks { get; set; }
        public string Regisseur { get; set; }
        public string Naam { get; set; }
        public int Releasejaar { get; set; }
        public List<Rol> Rollen { get; set; }

        public Film(Reeks reeks, string naam, string regisseur, int release, params Rol[] rollen)
        {
            Reeks = reeks;
            Naam = naam;
            Regisseur = regisseur;
            Releasejaar = release;
            Rollen = rollen.ToList();
        }

        public override string ToString() => $"{(string.IsNullOrEmpty(Reeks?.Naam) ? "" : $"{Reeks.Naam}: ")}{Naam} ({Releasejaar})";
    }
}
