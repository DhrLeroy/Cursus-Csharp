using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_databank
{
    internal class Voertuig
    {
        public int Id { get; set; }
        public string Merk { get; set; }
        public string Model { get; set; }
        public double Maximale_snelheid_km_u { get; set; }
        public bool Elektrisch { get; set; }

        public Voertuig(string merk, string model, double maximale_snelheid_km_u, bool elektrisch)
        {
            Merk = merk;
            Model = model;
            Maximale_snelheid_km_u = maximale_snelheid_km_u;
            Elektrisch = elektrisch;
        }
    }
}
