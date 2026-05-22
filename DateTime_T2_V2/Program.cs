Console.Write("Geef tijdsduur (uur:minuut): ");
TimeSpan interval = TimeSpan.Parse(Console.ReadLine());

// Input einddatum
Console.Write("Einddatum:\nDag: ");
var dag = Convert.ToInt32(Console.ReadLine());
Console.Write("Maand: ");
var maand = Convert.ToInt32(Console.ReadLine());
Console.Write("Jaar: ");
var jaar = Convert.ToInt32(Console.ReadLine());

var tot = new DateTime(jaar, maand, dag);

// Input boodschap
Console.Write("Geef boodschap: ");
string boodschap = Console.ReadLine();

Console.WriteLine("Alarmen:");

var start = DateTime.Now;

// Herhaal tot strikt vóór einddatum
while (start < tot)
{
    Console.WriteLine($"{start.ToString("d M yyyy - HH:mm:ss")} -> {boodschap}");

    // Volgend alarm
    start = start + interval;
}