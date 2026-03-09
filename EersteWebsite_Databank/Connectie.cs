using Klassen_EersteWebsite;
using Microsoft.EntityFrameworkCore;

namespace EersteWebsite_Databank
{
    public class Connectie : DbContext
    {
        public DbSet<Videogame> Videogames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("server=localhost;database=eerstewebsite_videogames;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(9, 4, 0)));
        }
    }
}
