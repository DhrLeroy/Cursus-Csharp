using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenApp.Klassen
{
    public class Boot
    {
        public float Gewicht_Ton { get; set; }
        public string Model { get; set; }
        public float Volume_m3 { get; set; }

        public Boot(float gewicht_Ton, string model, float volume_m3)
        {
            Gewicht_Ton = gewicht_Ton;
            Model = model;
            Volume_m3 = volume_m3;
        }
    }
}
