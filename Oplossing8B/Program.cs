Console.Write("Geef een einddatum in.\nDag: ");
var dag = Convert.ToInt32(Console.ReadLine());
Console.Write("Maand: ");
var maand = Convert.ToInt32(Console.ReadLine());
Console.Write("Jaar: ");
var jaar = Convert.ToInt32(Console.ReadLine());

var einddatum = new DateTime(jaar, maand, dag);

if(einddatum <= DateTime.Today)
{
    Console.WriteLine("Geen datum in de toekomst opgegeven!");
}
else
{
    var datum = DateTime.Today;
    while(datum.DayOfWeek != DayOfWeek.Monday)
    {
        datum = datum.AddDays(1);
    }
    while(datum < einddatum)
    {
        Console.WriteLine(datum.ToString("dddd, dd / MMMM / yy"));
        datum = datum.AddDays(7);
    }
}