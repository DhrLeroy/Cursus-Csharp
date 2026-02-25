namespace SimplePizzaWebsite
{
    public class Bestelling
    {
        public int Id { get; set; }
        public string Emailadres { get; set; }
        public DateTime Datum { get; set; }
        public List<Bestellijn> Bestellijnen { get; set; } = new List<Bestellijn>();
    
        public double BerekenTotaal()
        {
            return Math.Round(Bestellijnen.Sum(b => b.Pizza.Prijs * b.Aantal), 2);
        }
    
    }

    public class Bestellijn
    {
        public int Id { get; set; }
        public Pizza Pizza { get; set; }
        public Bestelling Bestelling { get; set; }
        public int Aantal { get; set; }
    }
}
