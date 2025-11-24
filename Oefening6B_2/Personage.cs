using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6B_2
{
    public class Personage
    {
        public string Naam { get; set; }
        public string Rol { get; set; } 
        public string Beschrijving { get; set; }
        public int Leeftijd { get; set; } 
        public string SpecialeKracht { get; set; }
        public bool IsSpeelbaar { get; set; }

        public Personage(string naam, string rol, string beschrijving, int leeftijd, string specialeKracht, bool isSpeelbaar)
        {
            Naam = naam;
            Rol = rol;
            Beschrijving = beschrijving;
            Leeftijd = leeftijd;
            SpecialeKracht = specialeKracht;
            IsSpeelbaar = isSpeelbaar;
        }
        public override string? ToString()
        {
            return $"{Naam} ({Rol})";
        }
    }

}
