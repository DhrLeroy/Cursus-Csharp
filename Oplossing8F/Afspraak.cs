using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing8F
{
    internal class Afspraak
    {
        public string Titel { get; set; }
        public DateTime Aanvangsuur { get; set; }
        public TimeSpan Duur { get; set; }
        public bool Dagelijks { get; set; }
        public bool Wekelijks { get; set; }
        public bool Maandelijks { get; set; }

        public Afspraak(string titel, DateTime aanvangsuur, TimeSpan duur, bool dagelijks, bool wekelijks, bool maandelijks)
        {
            Titel = titel;
            Aanvangsuur = aanvangsuur;
            Duur = duur;
            Dagelijks = dagelijks;
            Wekelijks = wekelijks;
            Maandelijks = maandelijks;
        }
    }
}
