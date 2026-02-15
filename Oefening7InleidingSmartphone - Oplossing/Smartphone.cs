using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening7InleidingSmartphone___Oplossing
{
    internal class Smartphone
    {
        public string Merk { get; set; }
        public string Model { get; set; }
        public double Prijs { get; set; }
        public double Kortingspercentage { get; set; }

        public Smartphone(string merk, string model, double prijs, double kortingspercentage)
        {
            Merk = merk;
            Model = model;
            Prijs = prijs;
            Kortingspercentage = kortingspercentage;
        }
    }
}
