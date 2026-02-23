using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databank_voorbeeld
{
    internal class Connectie : DbContext
    {
        public DbSet<Voertuig> Voertuigen { get; set; }

        protected override void
    }
}
