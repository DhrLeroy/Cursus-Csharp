using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing7B_overerving_
{
    public class Huisdier
    {
        public string Naam { get; set; }
        public string Ras { get; set; }
        public bool Mannelijk { get; set; }
        public string Eigenaar { get; set; }
        public int Geboortejaar { get; set; }
        public float Gewicht_kg { get; set; }

        public void Beschrijf()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string geslacht = "♀";
            if (Mannelijk)
                geslacht = "♂";
            Console.WriteLine($"{Naam} ({Ras}, {geslacht})");
        }

        public Huisdier(string naam, string ras, bool mannelijk)
        {
            Naam = naam;
            Ras = ras;
            Mannelijk = mannelijk;
        }
    }

    public class Hond : Huisdier
    {
        public bool IsAssistentiehond { get; set; }
        public int Bijtincidenten { get; set; }

        public Hond(string n, string r, bool m, bool a, int b) : base(n, r, m)
        {
            IsAssistentiehond = a;
            Bijtincidenten = b;
        }
    }

    public class Kat : Huisdier
    {
        public bool Infertiel { get; set; }
        public bool GaatBuiten { get; set; }
        public Kat(string n, string r, bool m) : base(n, r, m)
        {

        }

    }
}
