using IData;
using Microsoft.EntityFrameworkCore;
using MyGaming_Classes;

namespace MyGaming_MySQL
{
    public class MySQLDatabase : DbContext, IGameData
    {
        public DbSet<Game> Games { get; set; }

        public void AddGame(Game newgame)
        {
            Games.Add(newgame);
            SaveChanges();
        }

        public List<Game> GeefAlleGames()
        {
            return Games.ToList();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("MyGamingDb", EnvironmentVariableTarget.User),
                new MySqlServerVersion(new Version(8,2,0)));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Game>().Property(g => g.Genre)
                .HasConversion(g => g.ToString(), g => (Genre)Enum.Parse(typeof(Genre), g));
        }
    }
}
