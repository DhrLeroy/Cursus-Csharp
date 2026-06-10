using Microsoft.EntityFrameworkCore;
using PizzaKlassen;
using PizzaRestaurantData;

namespace PizzaMySQLDatabank
{
    public class PizzaConnectie : DbContext, IPizzaData
    {
        public DbSet<Pizza> Pizzas { get; set; }

        public bool BestaatPizzaMetId(int id)
        {
            return Pizzas.Any(p => p.Id == id);
        }

        public IList<Pizza> GeefAllePizzas()
        {
            return Pizzas.ToList();
        }

        public Pizza GeefPizzaById(int? id)
        {
            return Pizzas.Find(id);
        }

        public void UpdatePizza(Pizza pizza)
        {
            Attach(pizza).State = EntityState.Modified;
            SaveChanges();
        }

        public void VerwijderPizza(Pizza pizza)
        {
            Pizzas.Remove(pizza);
            SaveChanges();
        }

        public void VoegPizzaToe(Pizza pizza)
        {
            Pizzas.Add(pizza);
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("server=localhost;database=pizza;user=root;password=k9#Xm!2P$vR7*qLb;", new MySqlServerVersion(new Version(8, 0, 26)));
        }
    }
}
