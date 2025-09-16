using _12_1_Classes;

namespace Classes
{
    public enum Console
    {
        PC,
        PS4,
        PS5,
        XBOXOne,
        XBOXX,
        Switch2
    }

    public class Game
    {
        public int GameId { get; set; }
        public double Prijs { get; set; }
        public string Naam { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public Console Console { get; set; }
        public List<Aankoop> Licenties { get; set; }
    }
}
