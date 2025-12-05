Console.Write("Geef een tijdsinterval in: ");
var interval_split = Console.ReadLine().Split(":");
var interval = new TimeSpan(Convert.ToInt32(interval_split[0]), Convert.ToInt32(interval_split[1]), 0);

Console.Write("Geef een einddatum op: ");
Console.Write("Dag: ");
int dag = Convert.ToInt32(Console.ReadLine());
Console.Write("Maand: ");
int maand = Convert.ToInt32(Console.ReadLine());
Console.Write("Jaar: ");
int jaar = Convert.ToInt32(Console.ReadLine());

var einddatum = new DateTime(jaar, maand, dag);

var start = DateTime.Now + interval;

while (start < einddatum)
{
    Console.WriteLine($"Alarm om {start.ToString("dd MM yyyy, HH:mm")}");
    start = start + interval;
}