using Microsoft.EntityFrameworkCore;

namespace SimplePizzaWebsite
{
    public class Databank : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Bestelling> Bestellingen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("server=localhost;database=pizzawinkel;user=root;password=Peppa123$;", new MySqlServerVersion(new Version(9, 4, 0)));
        }
    }
}
