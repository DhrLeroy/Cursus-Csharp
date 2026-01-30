using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_School_Databank
{
    public class Leerling
    {
        public int LeerlingId { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public DateTime? Geboortedatum { get; set; }
        public Klas Klas { get; set; }

    }
}
