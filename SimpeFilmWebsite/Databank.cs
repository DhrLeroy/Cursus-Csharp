using Microsoft.EntityFrameworkCore;
using SimpeFilmWebsite.Klassen;

namespace SimpeFilmWebsite
{
    public class Databank : DbContext
    {
        public DbSet<Film> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("server=localhost;database=simple_films;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(9, 4, 0)));
        }
    }
}
