using _12_1_Classes;

namespace _12_1_Classes.Product
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

    public class Game : Product
    {
        public string Genre { get; set; }
        public int Rating { get; set; }
        public DateOnly Releasedatum { get; set; }
        public Console Console { get; set; }
        public List<Aankoop>? Licenties { get; set; }
    }
}
