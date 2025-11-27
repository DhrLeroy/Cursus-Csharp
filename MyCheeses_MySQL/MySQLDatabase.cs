using Microsoft.EntityFrameworkCore;
using MyCheeses_classes;
using MyCheeses_Data;

namespace MyCheeses_MySQL
{
    public class MySQLDatabase : DbContext, ICheeseData
    {
        public DbSet<Cheese> Cheeses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("Default_connectionstring", EnvironmentVariableTarget.User).Replace("#default#", "mycheesesapp"), 
                new MySqlServerVersion(new Version(9, 5, 0)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
