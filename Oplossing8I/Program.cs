List<TimeSpan> rondes = new List<TimeSpan>();

var stoppen = false;

var start = DateTime.Now;
Console.WriteLine("Start");

while(stoppen == false)
{
    rondes.Add(DateTime.Now - start);
    start = DateTime.Now;
    if(Console.ReadLine().Equals("stop", StringComparison.CurrentCultureIgnoreCase))
        stoppen = true;
    else
        Console.WriteLine("Ronde opgenomen.");
}

foreach(var r in rondes)
{
    Console.WriteLine($"{r.Hours}:{r.Minutes}:{r.Seconds}:{r.Milliseconds}");
}