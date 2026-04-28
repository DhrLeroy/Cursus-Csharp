using Microsoft.EntityFrameworkCore;

namespace TVSeries_Db
{
    public class Databank : DbContext
    {
        public DbSet<Serie> Series { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);

            optionsBuilder.UseMySql("server=localhost;database=tv_series;user=root;password=Peppa123$",
                new MySqlServerVersion(new Version(8, 4, 0)));
        }
    }
}
