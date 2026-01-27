using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Databank
{
    public class GP
    {
        public string Naam { get; set; }
        public int Jaartal { get; set; }
        public List<Deelname> Deelname { get; set; }

    }
    public class Deelnemer
    {
        public string Naam { get; set; }
        public string Land { get; set; }
    }

    public class Deelname
    {
        public Deelnemer Deelnemer { get; set; }
        public GP GP { get; set; }
        public List<Tussentijd> Tussentijden { get; set; }

    }
    public class Tussentijd
    {
        public int Volgorde { get; set; }
        public int Milliseconden { get; set; }
        public int Straftijd_seconden { get; set; }
    }
}
