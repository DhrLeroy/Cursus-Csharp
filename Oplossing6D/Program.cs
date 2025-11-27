using Films.Classes;
using Films.Data;

List<int> getallen = new List<int>() { -2, 0, 3, 4};
List<int> kwadraten = getallen.Select(g => g * g).ToList();

List<FilmReeks> filmReeksen = Data.GetData();

//filmreeks namen
List<string> namen_filmreeksen = filmReeksen.Select(fr => fr.Naam).ToList();
namen_filmreeksen.Clear();
foreach(FilmReeks fr in filmReeksen)
{
    namen_filmreeksen.Add(fr.Naam);
}

List<string> filmreeksen_met_aantal = filmReeksen.Select(fr => $"{fr.Naam} ({fr.Films.Count})").ToList();

// alle films
List<Film> alleFilms = filmReeksen.SelectMany(fr => fr.Films).ToList();
alleFilms.Clear();
foreach(FilmReeks fr in filmReeksen)
{
    foreach(Film f in fr.Films)
    {
        alleFilms.Add(f);
    }
}

// alle personages
List<Rol> personages = alleFilms.SelectMany(f => f.Rollen).ToList();

// alle acteurs
List<Acteur> acteurs = personages.SelectMany(r => r.Acteurs).ToList();


// alle personages (naam rol) in The Lord of the Rings
List<string> personages_lotr = filmReeksen.Where(fr => fr.Naam.Equals("The Lord of the rings", StringComparison.CurrentCultureIgnoreCase))
    .SelectMany(fr => fr.Films).SelectMany(f => f.Rollen).Select(r => r.Naam).Distinct().ToList();

// films met Hugo Weaving
List<Film> films_hugo_weaving = alleFilms.Where(
    f => f.Rollen.Where(
        r => r.Acteurs.Where(a => a.Naam.Equals("Hugo Weaving", StringComparison.CurrentCultureIgnoreCase)).ToList().Count > 0
        ).ToList().Count > 0
    ).ToList();

// films uit de jaren '80 (1980-1989)
List<Film> films_jaren80 = alleFilms.Where(f => f.Releasejaar >= 1980 && f.Releasejaar <= 1989).ToList();
films_jaren80 = alleFilms.Where(f => f.Releasejaar / 10 == 198).ToList();

// filmreeksen met Peter Jackson als regisseur
List<FilmReeks> reeksen_met_PJackson = filmReeksen.Where(fr =>
    fr.Films.Where(f =>
        f.Regisseur.Equals("Peter Jackson", StringComparison.CurrentCultureIgnoreCase)
        ).Count() > 0
    ).ToList();

// acteurs die Bilbo Baggins speelden
List<Acteur> acteurs_bilbo_baggins = personages.Distinct().Where(
    p => p.Naam.Equals("Bilbo Baggins", StringComparison.CurrentCultureIgnoreCase)
    ).SelectMany(p => p.Acteurs).ToList();

// titel (jaar) van films die niet beginnen met 'The'
List<string> films_zonder_the = alleFilms.Where(f => !f.Titel.StartsWith("The", StringComparison.CurrentCultureIgnoreCase))
    .Select(f => $"{f.Titel} ({f.Releasejaar})").ToList();

// films die in het begin van een decennium zijn uitgebracht
List<Film> films_begin_decennium = alleFilms.Where(f => f.Releasejaar % 10 == 0).ToList();

// titels van films met meer dan 2 rollen
List<Film> films_meerdan2rollen = alleFilms.Where(f => f.Rollen.Count > 2).ToList();

// acteurs wiens achternaam begint met een klinker
List<string> klinkers = new List<string>() { "A", "U", "I", "O", "E" };
List<Acteur> acteurs_klinker = acteurs.Where(a => klinkers.Contains(a.Naam.Substring(0, 1))).ToList();

// rollen met maar 1 naam (zonder voor- of achternaam)
List<Rol> rollen_1naam = personages.Where(p => !p.Naam.Trim().Contains(" ")).ToList();
rollen_1naam = personages.Where(p => p.Naam.Trim().IndexOf(" ") == -1).ToList();

Console.WriteLine();
Console.WriteLine();