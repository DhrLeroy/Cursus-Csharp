using Microsoft.EntityFrameworkCore;
using MovieReviewWebsite.Klassen;

namespace MovieReviewWebsite.Databank
{
    public class MySQLConnectie : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Acteur> Acteurs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("server=localhost;database=moviereview;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(9, 4, 0)));
        }


    }
}
