using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursie
{
    internal static class Binair_zoeken
    {
        public static int BinairZoeken(int[] lijst, int getal, int extra)
        {
            if (lijst.Length == 0)
                return -1;

            var midden = lijst.Length / 2;

            var middelste_waarde = lijst[midden];

            if (middelste_waarde == getal)
                return midden;
            else if(middelste_waarde > getal)
            {
                var tweede_deel = lijst[midden..];
                return BinairZoeken(tweede_deel, getal, midden + extra);
            }
            else
            {
                var eerste_deel = lijst[..midden];
                return BinairZoeken(eerste_deel, getal, extra);
            }

        }
    }
}
