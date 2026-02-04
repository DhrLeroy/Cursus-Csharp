namespace SimplePizzaWebsite
{
    public class Bestelling
    {
        public int Id { get; set; }
        public string Emailadres { get; set; }
        public string Adres { get; set; }
        public int Aantal_Margheritas { get; set; }
        public int Aantal_Hawaiis { get; set; }
        public int Aantal_Napolitanas { get; set; }

        public Bestelling()
        {
            
        }
        public Bestelling(string emailadres, string adres, int aantal_Margheritas, int aantal_Hawaiis, int aantal_Napolitanas)
        {
            Emailadres = emailadres;
            Adres = adres;
            Aantal_Margheritas = aantal_Margheritas;
            Aantal_Hawaiis = aantal_Hawaiis;
            Aantal_Napolitanas = aantal_Napolitanas;
        }
    }
}
