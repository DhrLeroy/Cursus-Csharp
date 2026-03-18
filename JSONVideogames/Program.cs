using JSONVideogames;
using System.Text.Json;

/*
 Opgave:
Maak een console applicatie waarbij je videogames (titel, genre en duurtijd in minuten) kan bijhouden in een JSON-bestand.
Eerst toon je alle opgeslagen videogames en vervolgens kan je er een nieuwe toevoegen.
 */

while (true)
{
    Console.WriteLine("Alle videogames: ");
    var json = File.ReadAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\JSONVideogames\\data.json");
    var games = JsonSerializer.Deserialize<List<Videogame>>(json);

    foreach(var game in games)
    {
        Console.WriteLine($"{game.Titel} - {game.Genre} ({game.Duurtijd_minuten} minuten)");
    }
    Console.Write("Wil je een nieuwe game toevoegen? (ja/nee) ");
    if(Console.ReadLine().Equals("ja", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.Write("Titel: ");
        var titel = Console.ReadLine();
        Console.Write("Genre: ");
        var genre = Console.ReadLine();
        Console.Write("Duurtijd in minuten: ");
        var duurtijd = Convert.ToInt32(Console.ReadLine());
        var game = new Videogame();
        game.Titel = titel;
        game.Genre = genre;
        game.Duurtijd_minuten = duurtijd;
        games.Add(game);
        json = JsonSerializer.Serialize(games);
        File.WriteAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\JSONVideogames\\data.json", json);
    }
}
