using Microsoft.EntityFrameworkCore;
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

    foreach (var s in seriesGesorteerdOpNaam)
    {
        Console.WriteLine($"{s.SerieId}. {s.Naam}: {s.Beschrijving}");
    }

    Console.Write("Wil je een nieuwe serie aanmaken? (y/n) ");
    if (Console.ReadLine().Equals("y", StringComparison.CurrentCultureIgnoreCase))
    {
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

    Console.Write("Wil je een serie bewerken? (y/n) ");
    if (Console.ReadLine().Equals("y", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.Write("Nummer van de serie: ");
        var id = Convert.ToInt32(Console.ReadLine());
        //var serie = db.Series.First(s => s.SerieId == id);
        var serie = db.Series
            .Include(s => s.Seizoenen).ThenInclude(s => s.Afleveringen)
            .First(s => s.SerieId == id);
        Console.WriteLine($"Naam: {serie.Naam}");
        Console.WriteLine($"Beschrijving: {serie.Beschrijving}");
        Console.WriteLine("Seizoenen");
        foreach(var seizoen in serie.Seizoenen)
        {
            Console.WriteLine($"Seizoen {seizoen.Volgnummer}");
        }
        Console.Write("Wil je een seizoen toevoegen? (y/n) ");
        if (Console.ReadLine().Equals("y", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Write("Volgnummer: ");
            var nummer = Convert.ToInt32(Console.ReadLine());
            var seizoen = new Seizoen();
            seizoen.Volgnummer = nummer;
            serie.Seizoenen.Add(seizoen);
            db.SaveChanges();
        }
        Console.Write("Wil je een seizoen bewerken? (y/n) ");
        if (Console.ReadLine().Equals("y", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Write("Volgnummer: ");
            var nummer = Convert.ToInt32(Console.ReadLine());
            var seizoen = serie.Seizoenen.First(s => s.Volgnummer == nummer);
            Console.WriteLine($"Seizoen {seizoen.Volgnummer}");
            Console.WriteLine("Afleveringen");
            foreach(var a in seizoen.Afleveringen)
            {
                Console.WriteLine($"{a.Titel} ({serie.Naam}, seizoen {seizoen.Volgnummer})");
            }
            Console.Write("Wil je een aflevering toevoegen? (y/n) ");
            if (Console.ReadLine().Equals("y", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.Write("Titel: ");
                var titel = Console.ReadLine();
                Console.Write("Rating (op 10): ");
                var rating = Convert.ToSingle(Console.ReadLine());
                var aflevering = new Aflevering();
                aflevering.Titel = titel;
                aflevering.Rating = rating;
                seizoen.Afleveringen.Add(aflevering);
                db.SaveChanges();
            }
        }
    }
}