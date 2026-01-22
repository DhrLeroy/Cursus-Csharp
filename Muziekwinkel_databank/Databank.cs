using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muziekwinkel_databank
{
    public class Databank : DbContext
    {
        public DbSet<Artiest> Artiesten { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=localhost;database=Muziekwinkel;user=root;Peppa123$"
                , new MySqlServerVersion(new Version(9, 5, 0)));
        }
    }
}
