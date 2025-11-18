//Lijst van ontwikkelaars
using LINQ_Games.Klassen;

var ontwikkelaars = Data.Ontwikkelaars();


//lijst van alle games
var games = ontwikkelaars.SelectMany(o => o.Games).ToList();

//lijst van alle personages
var personages = games.SelectMany(g => g.Personages).ToList();

//lijst van de titels van alle games


//lijst van alle personages in een 'Adventure' game


//lijst van ontwikkelaars met games met een beoordeling van minstens 9 (op 10)


//lijst van games met een slechterik (rol = "Slechterik")


//lijst van alle achievements van games van Rockstar Games


//lijst van alle achievements met een moeilijkheidsgraad van minstens 4


//lijst van alle games met Mario (personage)


//lijst van games met minstens 3 achievements
var x = games.Where(g => g.Achievements.Count() >= 3).ToList();



//lijst van minderjarige personages
var minderjarige_personages = personages.Where(p => p.Leeftijd < 18).ToList();

//lijst van games met meerdere speelbare personages
var games_speelbare_personages = games
    .Where(g => g.Personages.Where(p => p.IsSpeelbaar).ToList().Count > 1).ToList();


Console.WriteLine();
Console.WriteLine();