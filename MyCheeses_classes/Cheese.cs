namespace MyCheeses_classes
{
    public enum Melk
    {
        Onbekend = 0,
        Koemelk = 1,
        Schapenmelk = 2
    }

    public class Cheese
    {
        public int CheeseId { get; set; }
        public string Naam { get; set; }
        public float Prijs_kg { get; set; }
        public Melk Melk { get; set; }
    }
}
