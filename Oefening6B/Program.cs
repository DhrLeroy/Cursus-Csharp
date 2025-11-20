//Lijst van ontwikkelaars
using LINQ_Games.Klassen;

var ontwikkelaars = Data.Ontwikkelaars();

var namen = ontwikkelaars.Select(o => o.Naam).ToList();

//lijst van alle games
List<Game> games = ontwikkelaars.SelectMany(o => o.Games).ToList();

//lijst van alle personages
List<Personage> personages = ontwikkelaars
    .SelectMany(o => o.Games)
    .SelectMany(game => game.Personages).ToList();

//lijst van alle achievements
List<Achievement> achievements = games.SelectMany(game => game.Achievements).ToList();

//lijst van de titels van alle games


//lijst van alle personages in een 'Adventure' game


//lijst van ontwikkelaars met games met een beoordeling van minstens 9 (op 10)


//lijst van games met een slechterik (rol = "Slechterik")


//lijst van alle achievements van games van Rockstar Games


//lijst van alle achievements met een moeilijkheidsgraad van minstens 4


//lijst van alle games met Mario (personage)


//lijst van games met minstens 3 achievements



//lijst van minderjarige personages


//lijst van games met meerdere speelbare personages



Console.WriteLine();
Console.WriteLine();