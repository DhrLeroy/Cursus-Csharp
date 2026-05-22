using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing90C
{
    public class Bankrekening
    {
        private float Balans { get; set; }

        public Bankrekening(float balans)
        {
            Balans  = balans;
        }

        public void HaalAf(float bedrag) { 
            if(Balans < 0)
            {
                throw new Exception("Bedrag op rekening is negatief");
            }
            if(bedrag < 0)
            {
                throw new Exception("Je kan geen negatief bedrag afhalen");
            }
            if(bedrag > Balans)
            {
                throw new Exception("Je hebt niet zoveel op de rekening staan");
            }
        }
    }
}
