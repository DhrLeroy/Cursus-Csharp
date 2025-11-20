using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6C
{
    public class Data
    {
    }

    public class Planeet
    {
        public string Naam { get; set; }
        public double Aphelium_AU { get; set; }
        public double Perihelium_AU { get; set; }
        public double Halve_lange_as_AU { get; set; }


        public int Diameter_km { get; set; }
        public long Massa_kg { get; set; }


    }
}
