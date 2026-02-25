namespace SimplePizzaWebsite
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }

        public Pizza()
        {
            
        }

        public Pizza(int id, string naam, double prijs)
        {
            Id = id;
            Naam = naam;
            Prijs = prijs;
        }
    }

    public static class PizzaProvider
    {
        public static List<Pizza> Pizzas()
        {
            return new List<Pizza>()
            {
                new Pizza(1, "Margherita", 10.50),
                new Pizza(2, "Hawaii", 12),
                new Pizza(3, "Napolitana", 14.50)
            };
        }
    }
}
