namespace PizzaRestaurantWebsite.Klassen
{
    public enum Maat
    {
        Small,
        Medium,
        Large,
        XLarge
    }
    public class Pizza
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public Maat Maat { get; set; }
        public List<Bestelijn> Bestellijnen { get; set; }
    }

    public class Bestelling
    {
        public int Id { get; set; }
        public DateTime Datum {  get; set; }
        public List<Bestelijn> Bestellijnen { get; set; }
    }
    public class Bestelijn
    {
        public int Id { get; set; }
        public Bestelling Bestelling { get; set; }
        public Pizza Pizza { get; set; }
        public int Aantal { get; set; }
    }
}
