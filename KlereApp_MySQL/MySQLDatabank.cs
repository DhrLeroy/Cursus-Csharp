using KlereApp_Data;
using KlereApp_klassen;
using Microsoft.EntityFrameworkCore;

namespace KlereApp_MySQL
{
    public class MySQLDatabank : DbContext, IKledijData
    {
        public DbSet<Kledij> Kledij { get; set; }

        private void VulDatabank()
        {
            if(Kledij.Count() == 0)
            {
                var broekSpringfield = new Kledij("Blauw", "Broek", "Springfield", 32, 33);
                var truiAdidas = new Kledij("Wit", "Trui", "Adidas", 40, 41, 43);
                var tshirtDecathlon = new Kledij("Groen", "T-shirt", "Decathlon", 38, 39);
                Kledij.Add(broekSpringfield);
                Kledij.Add(truiAdidas);
                Kledij.Add(tshirtDecathlon);
                SaveChanges();
            }
        }

        public List<Kledij> GeefAlleKledij()
        {
            VulDatabank();
            return Kledij.ToList();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("Default_connectionstring", EnvironmentVariableTarget.User).Replace("#default#", "klere"),
                new MySqlServerVersion(new Version(9, 3, 0)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Kledij>().Property(k => k.Maten)
                .HasConversion(lijst_maten => string.Join(";", lijst_maten),
                                maten => maten.Split(";", StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToSingle(s)).ToList()
                             );
        }
    }
}
