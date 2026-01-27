using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muziekwinkel_databank
{
    public class Artiest
    {
        public int artiestid { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public int Geboortejaar { get; set; }
        public bool Is_Man { get; set; }
        public string Genre { get; set; }
        public bool Heeft_Beperking { get; set; }
        public List<CD> CDs { get; set; }

        public Artiest(string naam, string voornaam, string genre)
        {
            Naam = naam;
            Voornaam = voornaam;
            Genre = genre;
        }
    }
}
