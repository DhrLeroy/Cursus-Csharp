namespace SimplePizzaWebsite
{
    public class Bestelling
    {
        public int Id { get; set; }
        public string Emailadres { get; set; }
        public DateTime Datum { get; set; }
        public List<Bestellijn> Bestellijnen { get; set; } = new List<Bestellijn>();
    }

    public class Bestellijn
    {
        public int Id { get; set; }
        public Pizza Pizza { get; set; }
        public Bestelling Bestelling { get; set; }
        public int Aantal { get; set; }
    }
}
