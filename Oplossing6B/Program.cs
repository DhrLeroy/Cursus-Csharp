//Lijst van ontwikkelaars
using LINQ_Games.Klassen;

var ontwikkelaars = Data.Ontwikkelaars();


//lijst van alle games
var games = ontwikkelaars.SelectMany(o => o.Games).ToList();

//lijst van alle personages
var personages = games.SelectMany(g => g.Personages).ToList();

//lijst van de titels van alle games
var titels = games.Select(g => g.Titel).ToList();

//lijst van alle personages in een 'Adventure' game
List<Personage> personages_adventure = games
    .Where(g => g.Genre.Equals("Adventure", StringComparison.CurrentCultureIgnoreCase))
    .SelectMany(g => g.Personages).ToList();

//lijst van ontwikkelaars met games met een beoordeling van minstens 9 (op 10)
List<Ontwikkelaar> ontwikkelaar_games_minstens9_op10 = ontwikkelaars
    .Where(o => o.Games.Where(g => g.Beoordeling >= 9).Count() > 1).ToList();

//lijst van games met een slechterik (rol = "Slechterik")
List<Game> games_met_slechterik = games
    .Where(g => g.Personages
        .Where(p => p.Rol.Equals("Slechterik", StringComparison.CurrentCultureIgnoreCase)).Count() > 0).ToList();

//lijst van alle titels van de achievements van games van Rockstar Games
List<string> rockstar_achievements = ontwikkelaars
    .Where(o => o.Naam.Equals("Rockstar Games", StringComparison.CurrentCultureIgnoreCase))
    .SelectMany(o => o.Games)
    .SelectMany(g => g.Achievements)
    .Select(a => a.Naam).ToList();

//lijst van alle achievements met een moeilijkheidsgraad van minstens 4
List<Achievement> achievements_minstens_niveau_4 =
    games.SelectMany(g => g.Achievements)
    .Where(a => a.Moeilijkheidsgraad >= 4).ToList();

//lijst van alle games met Mario (personage)
List<Game> games_met_Mario = games
    .Where(g => g.Personages
        .Where(p => p.Naam.Equals("Mario", StringComparison.CurrentCultureIgnoreCase)).Count() > 0).ToList();

//lijst van titels van games met minstens 3 achievements
List<string> titels_minstens_3_achievements =
    games.Where(game => game.Achievements.Count >= 3).Select(game => game.Titel).ToList();


//lijst van minderjarige personages
List<Personage> minderjarige_personages =
    games.SelectMany(g => g.Personages).Where(p => p.Leeftijd < 18).ToList();

//lijst van games met meerdere speelbare personages
List<Game> games_speelbare_personageS =
    games.Where(g => g.Personages.Where(p => p.IsSpeelbaar).Count() > 1).ToList();


Console.WriteLine();
Console.WriteLine();