using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_School_Databank
{
    public class Connectie : DbContext
    {
        public DbSet<Leerling> Leerlingen { get; set; }
        public DbSet<Klas> Klassen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=localhost; database=school;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(9, 10, 0)));
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Klas>().HasKey(k => k.Naam);

            modelBuilder.Entity<Leerling>().Property(l => l.Voornaam).HasColumnName("First name");
            modelBuilder.Entity<Leerling>().Property(l => l.Naam).HasColumnName("Last name");
        
            
        }
    }
}
