using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracker
{
    internal class Dier
    {
        public int Id { get; set; }
        public string Soort { get; set; }

        public Dier()
        {
            
        }

        public Dier(string soort)
        {
            Soort = soort;
        }
    }
}
