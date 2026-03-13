namespace Klassen_EersteWebsite
{
    public class Videogame
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public string Studio { get; set; }
        public List<Character> Characters { get; set; }
    }

    public class Character
    {
        public int Id { get; set; }
        public string Naam { get; set; }
    }
}
