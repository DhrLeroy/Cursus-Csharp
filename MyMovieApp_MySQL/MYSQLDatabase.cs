using Microsoft.EntityFrameworkCore;
using MyMovieApp_classes;
using MyMovieApp_Data;

namespace MyMovieApp_MySQL
{
    public class MYSQLDatabase : DbContext, IMovieData
    {
        public DbSet<Movie> Movies { get; set; }

        public void SaveMovie(Movie movie)
        {
            Movies.Add(movie);
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("MyMovieApp_connectionstring", EnvironmentVariableTarget.User),
                new MySqlServerVersion(new Version(9,5,0)));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
