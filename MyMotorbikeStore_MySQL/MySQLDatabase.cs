using Microsoft.EntityFrameworkCore;
using MyMotorbikeStore_classes;
using MyMotorbikeStore_Data;

namespace MyMotorbikeStore_MySQL
{
    public class MySQLDatabase : DbContext, IMotorbikeData
    {
        public DbSet<Motorbike> Motorbikes { get; set; }

        public void AddMotorbike(Motorbike nieuweMotor)
        {
            Motorbikes.Add(nieuweMotor);
            var aantal_aanpassingen = SaveChanges();
            /*if(aantal_aanpassingen == 1)
            {
                return true;
            }*/
        }

        public void DeleteMotorbike(int id)
        {
            var motor = GetMotorbikeById(id);
            Motorbikes.Remove(motor);
            SaveChanges();
        }

        public List<Motorbike> GetAllMotorbikes()
        {
            return Motorbikes.ToList();
        }

        public Motorbike GetMotorbikeById(int id)
        {
    
            return Motorbikes.First(m => m.Id == id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("Default_connectionstring", EnvironmentVariableTarget.User).Replace("#default#", "mymotorbikestore"),
                new MySqlServerVersion(new Version(9, 3, 0)));
        }
    }
}
