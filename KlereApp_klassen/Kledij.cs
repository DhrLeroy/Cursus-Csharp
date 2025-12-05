namespace KlereApp_klassen
{
    public class Kledij
    {
        public int Id { get; set; }
        public String Kleur { get; set; }
        public List<float> Maten { get; set; }
        public string Type { get; set; }
        public string Merk { get; set; }


        public Kledij(string kleur, string type, string merk, params float[] maten)
        {
            Kleur = kleur;
            Maten = maten.ToList();
            Type = type;
            Merk = merk;
        }

        public Kledij()
        {
        }
    }
}
