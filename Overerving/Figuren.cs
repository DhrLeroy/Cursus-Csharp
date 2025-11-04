using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    public class Figuur2D
    {
        public float Lengte { get; set; }
        public float Breedte { get; set; }
    }

    public class Vierkant : Figuur2D
    {
        public Vierkant(float zijde)
        {
            Breedte = zijde;
            Lengte = zijde;
        }
    }

    public class Rechthoek : Figuur2D
    {

    }
}
