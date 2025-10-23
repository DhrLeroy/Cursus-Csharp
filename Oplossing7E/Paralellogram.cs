using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing7E
{
    public class Paralellogram
    {
        public float Schuine_zijde { get; set; }
        public float Basis { get; set; }
        public float Scherpe_hoek { get; set; }

        public Paralellogram(float schuine_zijde, float basis, float scherpe_hoek)
        {
            Schuine_zijde = schuine_zijde;
            Basis = basis;
            Scherpe_hoek = scherpe_hoek;
        }

        public float Oppervlakte()
        {
            var hoogte = Schuine_zijde * (float)Math.Sin(Scherpe_hoek * Math.PI / 180);
            return Basis * hoogte;
        }
    }
}
