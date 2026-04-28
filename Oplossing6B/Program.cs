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
        .Any(p => p.Rol.Equals("Slechterik", StringComparison.CurrentCultureIgnoreCase))).ToList();

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


//lijst van ontwikkelaars die games in het Pools hebben uitgebracht
List<Ontwikkelaar> ontwikkelaars_pools =
    ontwikkelaars
    .Where(o => o.Games
                    .Any(g => g.Talen
                                .Any(t => t.Equals("Pools", StringComparison.CurrentCultureIgnoreCase))
                    )
    ).ToList();

ontwikkelaars_pools =
    ontwikkelaars.Where(o => o.Games.SelectMany(g => g.Talen).Contains("Pools")).ToList();

//de gemiddelde leeftijd van alle personages
var gemiddelde_leeftijd = personages.Average(p => p.Leeftijd);

//lijst van alle games, gesorteerd eerst op genre (A-Z) en dan op beoordeling (Hoog-laag).
var games_genre_beoordeling = games
    .OrderBy(g => g.Genre).ThenByDescending(g => g.Beoordeling)
    .Select(g => $"{g.Titel}: {g.Genre} ({g.Beoordeling}/10)")
    .ToList();

Console.WriteLine(string.Join("\n", games_genre_beoordeling));

//de gemiddelde leeftijd van alle personages in games van Bethesda Game Studios
var gemiddelde_leeftijd_personages_bethesda = 
    ontwikkelaars.First(o => o.Naam == "Bethesda Game Studios")
    .Games.SelectMany(g => g.Personages).Distinct().Average(p => p.Leeftijd);

//de gemiddelde leeftijd van alle helden (rol = "Held")
var gemiddelde_leeftijd_helden =
    personages.
    Where(p => p.Rol == "Held")
    .Average(p => p.Leeftijd);

//de spellen met het grootste verschil in oudste leeftijd tussen de helden en de slechteriken (enkel als die er zijn)
var spellen_met_held_slechterik =
    games.
    Where(g => g.Personages.Any(p => p.Rol == "Held") && g.Personages.Any(p => p.Rol == "Slechterik"));

var grootste_verschil_leeftijd_held_slechterik =
    spellen_met_held_slechterik.Max(
        s => Math.Abs(s.Personages.Where(p => p.Rol == "Held").Max(p => p.Leeftijd) -
             s.Personages.Where(p => p.Rol == "Slechterik").Max(p => p.Leeftijd)));

var games_met_grootst_verschil = spellen_met_held_slechterik.Where(
    s => Math.Abs(s.Personages.Where(p => p.Rol == "Held").Max(p => p.Leeftijd) -
             s.Personages.Where(p => p.Rol == "Slechterik").Max(p => p.Leeftijd)) 
                == grootste_verschil_leeftijd_held_slechterik
    ).ToList();

var spel_grootste_verschil_leeftijd_held_slechterik =
    spellen_met_held_slechterik.OrderByDescending(
        s => Math.Abs(s.Personages.Where(p => p.Rol == "Held").Max(p => p.Leeftijd) -
             s.Personages.Where(p => p.Rol == "Slechterik").Max(p => p.Leeftijd)))
    .First();


//geef alle talen die voorkomen in games (zonder duplicaten).
var alle_talen =
    games.SelectMany(g => g.Talen).Distinct();

//toon van alle games de ratio van de geheime en niet geheime achievements (bv.: 60% geheim, 40% niet geheim)
var ratios = games.Select(g =>
{
    var aantal_achievements = g.Achievements.Count;
    var aantal_geheim = g.Achievements.Count(a => a.IsGeheim);
    var aantal_niet_geheime = aantal_achievements - aantal_geheim;

    var str = $"{g.Titel}: {aantal_geheim*100/aantal_achievements}% geheim, " +
    $"{aantal_niet_geheime * 100 / aantal_achievements}% niet geheim";
    return str;
}).ToList();

//toon de titels van de top 3 best beoordeelde games


//toon de langste game per ontwikkelaar


//toon alle games met minstens één achievement van moeilijkheidsgraad 5


//sorteer alle games op rating (hoog naar laag), vervolgens op aantal achievements (hoog naar laag) en tenslotte op aantal personages (van laag naar hoog)



//Groepeer games per genre en toon per genre (toon het genre) de titels van de games na elkaar


//Geef per genre de gemiddelde beoordeling, gesorteerd van hoog naar laag.


//Geef de namen van alle speelbare personages uit games met een beoordeling > 9, gesorteerd op leeftijd.


//Geef per ontwikkelaar het totaal aantal achievements van al hun games, gesorteerd van hoog naar laag.


//Geef alle genres die voorkomen in games met een beoordeling > 8, zonder duplicaten, alfabetisch.


//Geef per franchise het gemiddelde van de speeltijd (in uren).


//Geef de top 3 beste games (geen gedeelde plaatsen o.b.v. beoordeling), gesorteerd op beoordeling van hoog naar laag


//Geef de top 3 beste games (met gedeelde plaatsen o.b.v. beoordeling), gesorteerd op beoordeling van hoog naar laag


//Groepeer de games per platform en toon in welke talen er allemaal games worden aangeboden


//Groepeer de games per genre en toon per genre de laagste en hoogste beoordeling van een game in dit genre.


//Groepeer de personages per leeftijdcategorie (0-10, 11-20, 21-30, ...) en toon per leeftijdscategorie de namen 'Helden'.


Console.WriteLine();
Console.WriteLine();