using TVSeries_Db;

var db = new Databank();

while (true)
{
    var series = db.Series
        .Where(s => !s.Beschrijving.Contains("kind"));

    var seriesGesorteerdOpNaam = series
        .OrderBy(s => s.Naam);
        //;

    Console.WriteLine();

    foreach(var s in seriesGesorteerdOpNaam)
    {
        Console.WriteLine($"{s.Naam}: {s.Beschrijving}");
    }


    Console.WriteLine("Nieuwe serie");

    Console.Write("Naam: ");
    var naam = Console.ReadLine();
    Console.Write("Beschrijving: ");
    var beschrijving = Console.ReadLine();

    var serie = new Serie();
    serie.Naam = naam;
    serie.Beschrijving = beschrijving;

    db.Series.Add(serie);
    db.SaveChanges();
}