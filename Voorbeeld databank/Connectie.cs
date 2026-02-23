using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_databank
{
    internal class Connectie : DbContext
    {

        public DbSet<Voertuig> Voertuigen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(
                "server=localhost;database=voorbeeld_voertuigen;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(9,0,4))
                );
        }
    }
}
