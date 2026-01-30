namespace MovieReviewWebsite.Klassen
{
    public class Film
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public List<Cast> Cast { get; set; } = new List<Cast>();
    }
    public class Cast
    {
        public int Id { get; set; }
        public Acteur Acteur { get; set; }
        public Film Film { get; set; }
        public string Rol { get; set; }
        public List<Rating> Ratings { get; set; } = new List<Rating>();
    }
    public class Acteur
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public List<Cast> Castings { get; set; } = new List<Cast>();
    }
    public class Rating
    {
        public int Id { get; set; }
        public Cast Casting { get; set; }
        public float Rating_on_10 { get; set; }
        public string Commentaar { get; set; }
    }
}
