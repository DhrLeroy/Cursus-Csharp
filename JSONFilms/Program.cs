using JSONFilms;
using System.Text.Json;

/*
 Opgave:
Maak een console applicatie waarbij je films (titel, hoofdacteur en rating op 10) kan bijhouden in een JSON-bestand.
Eerst toon je alle opgeslagen films (Titel, starring Hoofdacteur: Rating/10) en vervolgens kan je er een nieuwe toevoegen.
 */

var fruit = new List<string>();
for(int i = 0; i < 5; i++)
{
    fruit.Add(Console.ReadLine());
}
var fruit_A = fruit.Single(f => f.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
throw new InvalidOperationException("")

while (true)
{
    Console.WriteLine("Alle films: ");
    var json = File.ReadAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\JSONFilms\\data.json");
    var films = JsonSerializer.Deserialize<List<Film>>(json);

    foreach (var film in films)
    {
        Console.WriteLine($"{film.Titel}, starring {film.Hoofdacteur}: {film.Rating_op_10}/10");
    }
    Console.Write("Wil je een nieuwe film toevoegen? (ja/nee) ");
    if (Console.ReadLine().Equals("ja", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.Write("Titel: ");
        var titel = Console.ReadLine();
        Console.Write("Hoofdacteur: ");
        var hoofdacteur = Console.ReadLine();
        Console.Write("Rating (op 10): ");
        var rating = Convert.ToSingle(Console.ReadLine());
        var film = new Film();
        film.Titel = titel;
        film.Hoofdacteur = hoofdacteur;
        film.Rating_op_10 = rating;
        films.Add(film);
        json = JsonSerializer.Serialize(films);
        File.WriteAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\JSONFilms\\data.json", json);
    }
}
