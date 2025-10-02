using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin__oplossing_
{
    public class Verblijf
    {
        public int Oppervlakte { get; set; }
        public string Soort { get; set; }
        public string Bioom { get; set; }
        public int Capaciteit { get; set; }
        public List<Dier> Dieren { get; set; } = new List<Dier>();

        public Verblijf(int oppervlakte, string soort, int capaciteit)
        {
            Oppervlakte = oppervlakte;
            Soort = soort;
            Capaciteit = capaciteit;
        }

    }
}
