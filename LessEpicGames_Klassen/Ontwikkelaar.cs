using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessEpicGames_Klassen
{
    public class Ontwikkelaar
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public List<Videogame> Videogames { get; set; } = new List<Videogame>();
        public int Oprichtingsjaar { get; set; }
        public string Adres_HQ { get; set; }
        public string CEO { get; set; }

        public Ontwikkelaar(string naam)
        {
            Naam = naam;
            Adres_HQ = "";
            CEO = "";
        }
    }
}
