using _12_1_Classes;
using Classes;
using Microsoft.EntityFrameworkCore;

namespace MySql
{
    public class Databank : DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("ConnectionStringGameLibrary", EnvironmentVariableTarget.User)
                , new MySqlServerVersion(new Version(9,2,0)));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Gebruiker>().HasKey(g => g.Username);

            modelBuilder.Entity<Aankoop>().HasOne(a => a.Gebruiker).WithMany(g => g.Aankopen).HasForeignKey(a => a.Username);
            modelBuilder.Entity<Aankoop>().HasOne(a => a.Game).WithMany(g => g.Licenties).HasForeignKey(a => a.GameId);

            modelBuilder.Entity<Aankoop>().HasKey(a => new { a.Username, a.GameId });
        }
    }
}
