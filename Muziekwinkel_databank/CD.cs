using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muziekwinkel_databank
{
    public class CD
    {
        public Artiest Artiest { get; set; }
        public int CDId { get; set; }
        public string Titel { get; set; }
        public int Releasejaar { get; set; }
    }
}
