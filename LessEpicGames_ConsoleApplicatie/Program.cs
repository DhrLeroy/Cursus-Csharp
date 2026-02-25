using Databank;
using LessEpicGames_Klassen;
using Microsoft.EntityFrameworkCore;

var db = new MySQLDatabank();

while (true)
{
    Console.WriteLine("Videogames:");

    var videogames = db.Videogames.Include(v => v.Ontwikkelaars).ToList();

    foreach (var v in videogames)
    {
        Console.WriteLine($"{v.Titel} ({string.Join(", ", v.Ontwikkelaars.Select(o => o.Naam))})");
    }

    Console.WriteLine("Nieuwe videogame toevoegen");
    Console.Write("Titel: ");
    var titel = Console.ReadLine();
    Console.Write("Prijs: ");
    var prijs = Convert.ToDouble(Console.ReadLine());
    var game = new Videogame(titel, prijs);
    db.Add(game);

    Console.WriteLine("Ontwikkelaars: ");

    var ontwikkelaars = db.Videogames.SelectMany(v => v.Ontwikkelaars).Distinct().ToList();

    foreach (var o in ontwikkelaars)
    {
        Console.WriteLine($"{o.Id}: {o.Naam}");
    }
    Console.Write("Geef de id's in van de ontwikkelaars voor deze game (0 voor een nieuwe ontwikkelaar): ");
    var ids = Console.ReadLine();
    var splitIds = ids.Split(",").Select(s => Convert.ToInt32(s)).ToList();
    foreach(var id in splitIds)
    {  
        if (id == 0){
            Console.Write("Naam van de nieuwe ontwikkelaar: ");
            var naam = Console.ReadLine();
            var ontwikkelaar = new Ontwikkelaar(naam);
            game.Ontwikkelaars.Add(ontwikkelaar);
        }
        else
        {
            var ontwikkelaar = ontwikkelaars.First(o => o.Id == id);
            game.Ontwikkelaars.Add(ontwikkelaar);
        }
    }

    db.SaveChanges();

}