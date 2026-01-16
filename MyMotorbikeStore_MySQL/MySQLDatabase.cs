using Microsoft.EntityFrameworkCore;
using MyMotorbikeStore_classes;
using MyMotorbikeStore_Data;

namespace MyMotorbikeStore_MySQL
{
    public class MySQLDatabase : DbContext, IMotorbikeData
    {
        public DbSet<Motorbike> Motorbikes { get; set; }

        public List<Motorbike> GetAllMotorbikes()
        {
            return Motorbikes.ToList();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("Default_connectionstring", EnvironmentVariableTarget.User).Replace("#default#", "mymotorbikestore"),
                new MySqlServerVersion(new Version(9, 3, 0)));
        }
    }
}
