Console.Write("Dag: ");
int dag = Convert.ToInt32(Console.ReadLine());
Console.Write("Maand: ");
int maand = Convert.ToInt32(Console.ReadLine());
Console.Write("Jaar: ");
int jaar = Convert.ToInt32(Console.ReadLine());

var trouwdatum = new DateTime(jaar, maand, dag);

List<DateTime> jubilea = new List<DateTime>()
{
    trouwdatum.AddYears(1),
    trouwdatum.AddYears(12).AddMonths(6),
    trouwdatum.AddYears(25),
    trouwdatum.AddYears(50),
    trouwdatum.AddYears(60)
};

List<string> jubilea_namen = new List<string>()
{
    "Katoen",
    "Koper",
    "Zilver",
    "Goud",
    "Diamant"
};

Console.WriteLine("\nVolgende jubilea: ");

for (int i = 0; i < jubilea.Count; i++)
{
    var jubileum = jubilea[i];
    var naam = jubilea_namen[i];

    if (jubileum > DateTime.Today)
        Console.WriteLine($"{naam} op {jubileum.ToString("d MMMM yyyy")}");
}