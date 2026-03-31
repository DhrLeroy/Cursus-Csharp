using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracker
{
    internal class Connection : DbContext
    {
        public DbSet<Dier> Dieren { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("server=localhost;database=dieren_changetracker;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(9, 6, 0)));
        }
    }
}
