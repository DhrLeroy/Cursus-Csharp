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


//lijst van ontwikkelaars die games in het Pools hebben uitgebracht


//de gemiddelde leeftijd van alle personages


//lijst van alle games, gesorteerd eerst op genre en dan op beoordeling.


//de gemiddelde leeftijd van alle personages in games van Bethesda Game Studios


//de gemiddelde leeftijd van alle helden (rol = "Held")


//het spel met het grootste verschil in leeftijd tussen de helden en de slechteriken (enkel als die er zijn)


//geef alle talen die voorkomen in games (zonder duplicaten).


//toon van alle games de ratio van de geheime en niet geheime achievements (bv.: 60% geheim, 40% niet geheim)


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