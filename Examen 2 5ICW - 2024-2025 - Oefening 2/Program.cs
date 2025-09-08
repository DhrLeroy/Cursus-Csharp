using LINQ_Games.Klassen;

var ontwikkelaars = Data.Ontwikkelaars();

var games = ontwikkelaars.SelectMany(o => o.Games).ToList();

var personages = games.SelectMany(g => g.Personages).ToList();

var achievements = games.SelectMany(g => g.Achievements).ToList();

string ontwikkelaar_minste_games = ontwikkelaars
    .OrderBy(o => o.Games.Count).First().Naam;

//stel meerdere met laagste games

List<string> ontwikkelaars_minste_games = ontwikkelaars
    .Where(o => o.Games.Count == ontwikkelaars.Select(o => o.Games.Count).Min())
    .Select(o => o.Naam).ToList();

string naam_oudste_game = games.OrderBy(g => g.Releasedatum)
    .First().Titel;

List<Game> games20102019 = games
    .Where(g => g.Releasedatum.Year >= 2010 && g.Releasedatum.Year <= 2019)
    .OrderBy(g => g.Releasedatum)
    .ToList();

List<Achievement> verborgenAchievements = achievements
    .Where(a => a.IsGeheim).ToList();

List<Personage> louPersonages = games
    .Where(g => g.Franchise == "The Last of Us’")
    .SelectMany(g => g.Personages).Where(p => p.IsSpeelbaar).ToList();

//of

List<Personage> louPersonages2 = personages
    .Where(p => p.IsSpeelbaar && p.Games.Any(g => g.Franchise == "The Last of Us"))
    .ToList();

List<Achievement> superMarioAchievements = games.Where(g => g.Franchise == "Super Mario")
    .SelectMany(g => g.Achievements).ToList();

int moeilijksteMoeilijkheidsgraadSuperMarioAchievements =
    superMarioAchievements.Max(a => a.Moeilijkheidsgraad);

List<Achievement> moeilijksteSuperMarioAchievements =
    superMarioAchievements.Where(a => a.Moeilijkheidsgraad == superMarioAchievements.Max(a => a.Moeilijkheidsgraad)).ToList();

List<string> speelbarePersonages = personages.Where(p => p.IsSpeelbaar)
    .OrderByDescending(p => p.Leeftijd).ThenBy(p => p.Naam)
    .Select(p => $"{p.Naam} ({p.Leeftijd})").ToList();

bool alleGamesMakkelijksteAchievement = games
    .All(g => g.Achievements.Any(a => a.Moeilijkheidsgraad == 1));

List<TimeSpan> tijden = games.Select(g => g.Duur).OrderBy(d => d).ToList();

TimeSpan min =  tijden.Min();
TimeSpan max = tijden.Max();
TimeSpan q1 = tijden[tijden.Count / 4];
TimeSpan q2 = tijden[tijden.Count / 2];
TimeSpan q3 = tijden[tijden.Count / 4 * 3];

Console.WriteLine($"{min}|--|{q1}--{q2}--{q3}|--|{max}");