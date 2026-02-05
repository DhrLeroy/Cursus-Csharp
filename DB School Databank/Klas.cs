using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_School_Databank
{
    public class Klas
    {
        public string Naam { get; set; }
        public virtual ICollection<Leerling> Leerlingen { get; set; } = new List<Leerling>();
    }
}
