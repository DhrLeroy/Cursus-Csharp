using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Databanken
{
    public class Connectie : DbContext
    {
        public DbSet<Auteur> Auteurs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("server=localhost;database=bibliotheek;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(9, 4, 0)));

        }
    }
}
