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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("MyGamingDb", EnvironmentVariableTarget.User),
                new MySqlServerVersion(new Version(8,2,0)));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
