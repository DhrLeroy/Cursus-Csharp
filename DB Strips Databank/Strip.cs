namespace DB_Strips_Databank
{
    public class Strip
    {
        public int Id { get; set; }
        public Album Album { get; set; }
        public int Jaar_druk { get; set; }
        public string Staat { get; set; }
        public float Prijs { get; set; }

    }

    public class Album
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Serie { get; set; }
        public Tekenaar Tekenaar { get; set; }
        public string Titel { get; set; }
        public int VolgordeNummer { get; set; }
        public List<Strip> Exemplaren { get; set; }
    }

    public class Tekenaar
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public List<Album> Albums { get; set; }

    }
}
