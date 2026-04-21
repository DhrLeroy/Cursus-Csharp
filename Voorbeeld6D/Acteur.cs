using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films.Classes
{
    public class Acteur
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public List<Rol> Rollen { get; set; }

        public Acteur(string naam, string voornaam, params Rol[] rollen)
        {
            Naam = naam;
            Voornaam = voornaam;
            Rollen = rollen.ToList();
        }

        public override string ToString() => $"{Voornaam} {Naam}";
    }
}
