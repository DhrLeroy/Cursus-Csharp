using CRUD_Gezelschapsspelletjes;
using System.Text.Json;

while (true)
{
    Console.Write("Wil je de databank of het JSON-bestand gebruiken?");

    var antwoord = Console.ReadLine();

    if (antwoord.Equals("JSON", StringComparison.CurrentCultureIgnoreCase))
    {
        var json = File.ReadAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\CRUD_Gezelschapsspelletjes\\data.json");
        var gezelschapspelletjes = JsonSerializer.Deserialize<List<Gezelschapsspel>>(json);
        // READ
        foreach(var spel in gezelschapspelletjes)
        {
            Console.WriteLine(spel.Titel);
        }
        Console.Write("Wat wil je doen? (C: nieuw gezelschapsspel aanmaken, U: bestaand gezelschapsspel aanpassen, D: bestaand gezelschapsspel verwijderen) ");
        antwoord = Console.ReadLine();

        if(antwoord.Equals("c", StringComparison.CurrentCultureIgnoreCase))
        {
            var g = new Gezelschapsspel();
            Console.Write("Titel: ");
            g.Titel = Console.ReadLine();
            Console.Write("Omschrijving: ");
            g.Beschrijving = Console.ReadLine();
            Console.Write("Minimum aantal spelers: ");
            g.Minimum_Spelers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maximum aantal spelers: ");
            g.Maximum_Spelers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Werkt het op batterijen (ja/nee)? ");
            g.WerktOpBatterijen = Console.ReadLine().Equals("ja", StringComparison.CurrentCultureIgnoreCase);
            gezelschapspelletjes.Add(g);
        }
        if (antwoord.Equals("u", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Write("Welk spelletje wil je aanpassen? ");
            var spel = Console.ReadLine();

            var spelletje = gezelschapspelletjes.First(g => g.Titel.Equals(spel, StringComparison.CurrentCultureIgnoreCase));

            Console.Write($"Titel ({spelletje.Titel}): ");
            spelletje.Titel = Console.ReadLine();
            Console.Write($"Omschrijving ({spelletje.Beschrijving}): ");
            spelletje.Beschrijving = Console.ReadLine();
            Console.Write($"Minimum aantal spelers ({spelletje.Minimum_Spelers}): ");
            spelletje.Minimum_Spelers = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Maximum aantal spelers ({spelletje.Maximum_Spelers}): ");
            spelletje.Maximum_Spelers = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Werkt het op batterijen ({(spelletje.WerktOpBatterijen ? "ja" : "nee")}) (ja/nee)? ");
            spelletje.WerktOpBatterijen = Console.ReadLine().Equals("ja", StringComparison.CurrentCultureIgnoreCase);
        }
        if (antwoord.Equals("d", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Write("Welk spelletje wil je verwijderen? ");
            var spel = Console.ReadLine();

            var spelletje = gezelschapspelletjes.First(g => g.Titel.Equals(spel, StringComparison.CurrentCultureIgnoreCase));

            gezelschapspelletjes.Remove(spelletje);
        }


        json = JsonSerializer.Serialize(gezelschapspelletjes);
        File.WriteAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\CRUD_Gezelschapsspelletjes\\data.json", json);
        
    }
    else if (antwoord.Equals("databank", StringComparison.CurrentCultureIgnoreCase))
    {
        var db = new Connectie();
        // READ
        foreach (var spel in db.Gezelschapsspelletjes)
        {
            Console.WriteLine($"{}"spel.Titel);
        }
        Console.Write("Wat wil je doen? (C: nieuw gezelschapsspel aanmaken, U: bestaand gezelschapsspel aanpassen, D: bestaand gezelschapsspel verwijderen) ");
        antwoord = Console.ReadLine();

        if (antwoord.Equals("c", StringComparison.CurrentCultureIgnoreCase))
        {
            var g = new Gezelschapsspel();
            Console.Write("Titel: ");
            g.Titel = Console.ReadLine();
            Console.Write("Omschrijving: ");
            g.Beschrijving = Console.ReadLine();
            Console.Write("Minimum aantal spelers: ");
            g.Minimum_Spelers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maximum aantal spelers: ");
            g.Maximum_Spelers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Werkt het op batterijen (ja/nee)? ");
            g.WerktOpBatterijen = Console.ReadLine().Equals("ja", StringComparison.CurrentCultureIgnoreCase);
            db.Gezelschapsspelletjes.Add(g);
        }
        if (antwoord.Equals("u", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Write("Welk spelletje wil je aanpassen? ");
            var id = Convert.ToInt32(Console.ReadLine());

            var spelletje = gezelschapspelletjes.First(g => g.Titel.Equals(spel, StringComparison.CurrentCultureIgnoreCase));

            Console.Write($"Titel ({spelletje.Titel}): ");
            spelletje.Titel = Console.ReadLine();
            Console.Write($"Omschrijving ({spelletje.Beschrijving}): ");
            spelletje.Beschrijving = Console.ReadLine();
            Console.Write($"Minimum aantal spelers ({spelletje.Minimum_Spelers}): ");
            spelletje.Minimum_Spelers = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Maximum aantal spelers ({spelletje.Maximum_Spelers}): ");
            spelletje.Maximum_Spelers = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Werkt het op batterijen ({(spelletje.WerktOpBatterijen ? "ja" : "nee")}) (ja/nee)? ");
            spelletje.WerktOpBatterijen = Console.ReadLine().Equals("ja", StringComparison.CurrentCultureIgnoreCase);
        }
        if (antwoord.Equals("d", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Write("Welk spelletje wil je verwijderen? ");
            var spel = Console.ReadLine();

            var spelletje = gezelschapspelletjes.First(g => g.Titel.Equals(spel, StringComparison.CurrentCultureIgnoreCase));

            gezelschapspelletjes.Remove(spelletje);
        }


        json = JsonSerializer.Serialize(gezelschapspelletjes);
        File.WriteAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\CRUD_Gezelschapsspelletjes\\data.json", json);
    }
}

