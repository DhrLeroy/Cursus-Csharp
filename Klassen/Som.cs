using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Som
    {
        public string Uitvoerder { get; set; } = "Onbekend";
        List<int> getallen { get; set; } = new List<int>();

        public Som(string uitvoerder, params int[] getallen)
        {
            this.getallen = getallen.ToList();
            Uitvoerder = uitvoerder;
        }

        public void VoegGetalToe(int getal)
        {
            getallen.Add(getal);
        }

        public int BerekenSom()
        {
            int som = 0;
            foreach (var getal in getallen)
            {
                som += getal;
            }
            return som;
        }
    }
}
