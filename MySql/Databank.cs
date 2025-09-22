using _12_1_Classes;
using _12_1_Classes.Product;
using Microsoft.EntityFrameworkCore;

namespace MySql
{
    public class Databank : DbContext
    {
        public DbSet<Product> Producten { get; set; }
        public DbSet<Merchandise> Merchandises { get; set; }
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

            modelBuilder.Entity<Product>().UseTpcMappingStrategy();
            modelBuilder.Entity<Merchandise>().ToTable("Merch");
            modelBuilder.Entity<Game>().ToTable("Games");

            modelBuilder.Entity<Product>().Property(m => m.Prijs).HasPrecision(2).IsRequired(false);

            modelBuilder.Entity<Product>().Property(p => p.Naam).HasMaxLength(100).IsRequired();

            modelBuilder.Entity<Merchandise>().OwnsOne(m => m.Afmeting);
        }
    }
}
