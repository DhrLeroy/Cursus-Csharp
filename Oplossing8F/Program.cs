using Oplossing8F;
using System.Text.Json;

var afspraken = JsonSerializer.Deserialize<List<Afspraak>>(File.ReadAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\Oplossing8F\\afspraken.json"));

Console.WriteLine("Maandag\t\tDinsdag\t\tWoensdag\tDonderdag\tVrijdag\t\tZaterdag\tZondag");

var dag = DateTime.Today;

while (dag < DateTime.Today.AddMonths(3))
{
    if(dag.Day == 1 || dag == DateTime.Today)
    {
        
        Console.WriteLine($"\n{dag.ToString("MMMM").ToUpper()}");
        if (dag.DayOfWeek == DayOfWeek.Tuesday)
            Console.Write("\t\t");
        else if (dag.DayOfWeek == DayOfWeek.Wednesday)
            Console.Write("\t\t\t\t");
        else if (dag.DayOfWeek == DayOfWeek.Thursday)
            Console.Write("\t\t\t\t\t\t");
        else if (dag.DayOfWeek == DayOfWeek.Friday)
            Console.Write("\t\t\t\t\t\t\t\t");
        else if (dag.DayOfWeek == DayOfWeek.Saturday)
            Console.Write("\t\t\t\t\t\t\t\t\t");
        else if (dag.DayOfWeek == DayOfWeek.Sunday)
            Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
    }
    var afspraken_dag = afspraken.Where(a => a.Aanvangsuur.Date == dag);
    var afspraken_maandelijks = afspraken.Where(a => a.Aanvangsuur.Date <= dag && a.Aanvangsuur.Day == dag.Day && a.Maandelijks);
    var afspraken_wekelijks = afspraken.Where(a => a.Aanvangsuur.Date <= dag && a.Aanvangsuur.DayOfWeek == dag.DayOfWeek && a.Wekelijks);
    var afspraken_dagelijks = afspraken.Where(a => a.Aanvangsuur.Date <= dag && a.Dagelijks);
    var aantal_afspraken = afspraken_dag.Union(afspraken_maandelijks).Union(afspraken_wekelijks).Union(afspraken_dagelijks).Count();

    var uitvoer = $"{dag.Day}{(aantal_afspraken > 0 ? $" ({aantal_afspraken})" : "")}";
    if(dag.DayOfWeek == DayOfWeek.Sunday)
    {
        Console.WriteLine($"{uitvoer}\t\t");
    } 
    else
        Console.Write($"{uitvoer}\t\t");
    dag = dag.AddDays(1);
}

Console.WriteLine("Geef een datum in");
Console.Write("Dag: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Maand: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Jaar: ");
int j = Convert.ToInt32(Console.ReadLine());

var gekozen_dag = new DateTime(j, m, d);
if(gekozen_dag >= DateTime.Today && gekozen_dag <= DateTime.Today.AddMonths(3))
{
    var afspraken_dag = afspraken.Where(a => a.Aanvangsuur.Date <= gekozen_dag && a.Aanvangsuur.Add(a.Duur).Date >= gekozen_dag );
    var afspraken_maandelijks = afspraken.Where(a => a.Aanvangsuur.Date < gekozen_dag && a.Aanvangsuur.Day <= gekozen_dag.Day && a.Aanvangsuur.Add(a.Duur).Day >= gekozen_dag.Day && a.Maandelijks);
    var afspraken_wekelijks = afspraken.Where(a => a.Aanvangsuur.Date <= gekozen_dag.Date && a.Aanvangsuur.Add(a.Duur).Date >= gekozen_dag.Date && a.Aanvangsuur.DayOfWeek == gekozen_dag.DayOfWeek && a.Wekelijks);
    var afspraken_dagelijks = afspraken.Where(a => a.Aanvangsuur.Date <= gekozen_dag && a.Dagelijks);
    var alle_afspraken = afspraken_dag.Union(afspraken_maandelijks).Union(afspraken_wekelijks).Union(afspraken_dagelijks)
        .OrderBy(a => a.Aanvangsuur).ToList();

    foreach(var afspraak in afspraken)
        Console.WriteLine($"{afspraak.Titel}: {afspraak.Aanvangsuur.ToString("h:m:s")} - {afspraak.Aanvangsuur.Add(afspraak.Duur).ToString("h:m:s")}");

    Console.Write("Wil je een nieuwe afspraak invoegen? ");
    var keuze = Console.ReadLine().Equals("ja", StringComparison.CurrentCultureIgnoreCase);
    if (keuze)
    {
        Console.Write("Titel: ");
        var titel = Console.ReadLine();
        Console.WriteLine("Duurtijd: ");
        Console.Write("Aantal uur: ");
        int uur = Convert.ToInt32(Console.ReadLine());
        Console.Write("Aantal minuten: ");
        int minuten = Convert.ToInt32(Console.ReadLine());
        Console.Write("Aantal seconden: ");
        int seconden = Convert.ToInt32(Console.ReadLine());
        var duur = new TimeSpan(uur, minuten, seconden);
    }

}
else
{
    Console.WriteLine($"{gekozen_dag.ToString("dddd d MMMM yyyy")} ligt buiten deze kalender.");
}