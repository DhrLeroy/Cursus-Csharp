using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    public class TeamMetAantalAutos
    {
        public string Teamnaam { get; set; }
        public int Aantal_autos { get; set; }
        public int Aantal_drivers { get; set; }
        public int Aantal_deelnames { get; set; }

        public TeamMetAantalAutos(string teamnaam, int aantal_autos, int aantal_drivers, int aantal_deelnames)
        {
            Teamnaam = teamnaam;
            Aantal_autos = aantal_autos;
            Aantal_drivers = aantal_drivers;
            Aantal_deelnames = aantal_deelnames;
        }
    }
}
