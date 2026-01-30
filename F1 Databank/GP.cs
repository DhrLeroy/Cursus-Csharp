using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Databank
{
    public class GP
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Jaartal { get; set; }
        public virtual List<Deelname> Deelnames { get; set; } = new List<Deelname>();

    }
    public class Driver
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Land { get; set; }
    }

    public class Deelname
    {
        public int Id { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual GP GP { get; set; }
        public virtual List<Tussentijd> Tussentijden { get; set; }

    }
    public class Tussentijd
    {
        public int Id { get; set; }
        public int Volgorde { get; set; }
        public int Milliseconden { get; set; }
        public int Straftijd_seconden { get; set; }
    }
}
