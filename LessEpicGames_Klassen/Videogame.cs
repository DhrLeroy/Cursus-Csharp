namespace LessEpicGames_Klassen
{
    public class Videogame
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public double GemiddeldSpeeltijd_Uur { get; set; }
        public int Releasejaar { get; set; }
        public double Prijs { get; set; }
        public List<Ontwikkelaar> Ontwikkelaars { get; set; } = new List<Ontwikkelaar>();
        public List<Achievement> Achievements { get; set; } = new List<Achievement>();

        public Videogame(string titel, double prijs)
        {
            Titel = titel;
            Prijs = prijs;
        }

    }
}
