namespace MyRocks_klassen
{
    public class Rock
    {
        public int Diameter_cm { get; set; }
        public string Type { get; set; }
        public int Gewicht { get; set; }

        public Rock(int diameter_cm, string type, int gewicht)
        {
            Diameter_cm = diameter_cm;
            Type = type;
            Gewicht = gewicht;
        }
    }
}
