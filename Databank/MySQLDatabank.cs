using LessEpicGames_Klassen;
using Microsoft.EntityFrameworkCore;

namespace Databank
{
    public class MySQLDatabank : DbContext
    {
        public DbSet<Videogame> Videogames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("server=localhost;database=lessepicgames;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(9, 4, 0)));
        }
    }
}
