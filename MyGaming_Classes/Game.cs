namespace MyGaming_Classes
{
    public enum Genre
    {
        Horror,
        Action,
        Strategy
    }
    public class Game
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public float Rating { get; set; }
        public Genre Genre { get; set; }
        public int MinimumLeeftijd { get; set; }

    }
}
