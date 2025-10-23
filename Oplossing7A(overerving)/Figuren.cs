using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing7A_overerving_
{
    public class Figuur2D
    {
        public decimal Lengte { get; set; }
        public decimal Breedte { get; set; }
    }

    public class Vierkant : Rechthoek
    {
        public Vierkant(decimal zijde)
        {
            Lengte = zijde;
            Breedte = zijde;
        }
    }

    public class Rechthoek : Figuur2D
    {
        public Rechthoek()
        {
            
        }
        public Rechthoek(decimal lengte, decimal breedte)
        {
            Lengte = lengte;
            Breedte = breedte;
        }
        public decimal BerekenOppervlakte()
        {
            return Math.Round(Lengte * Breedte,4);
        }
        public decimal BerekenOmtrek()
        {
            return 2 * (Lengte + Breedte);
        }
    }
}
