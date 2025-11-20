namespace MyMovieApp_classes
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public DateTime Release { get; set; }
        public List<Actor> Cast { get; set; } = new List<Actor>();
    }
}
