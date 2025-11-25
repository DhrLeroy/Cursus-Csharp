using Films.Classes;
using Films.Data;

List<Reeks> filmReeksen = Data.GetData();

// alle films
List<Film> films = filmReeksen.SelectMany(f => f.Films).ToList();

// alle personages
List<Rol> rollen = films.SelectMany(f => f.Rollen).ToList();

// alle acteurs
List<Acteur> acteurs = rollen.SelectMany(r => r.Acteurs).ToList();


// alle personages (naam rol) in The Lord of the Rings
List<string> personages_rollen = filmReeksen
    .Where(f => f.Naam.Equals("The Lord of the Rings", StringComparison.CurrentCultureIgnoreCase))
    .SelectMany(f => f.Films)
    .SelectMany(f => f.Rollen)
    .Distinct()
    .Select(r => r.Naam)
    .ToList();

// films met Hugo Weaving
List<Film> films_hugo_weaving = films
    .Where(f =>
        f.Rollen.SelectMany(r => r.Acteurs)
        .Select(a => $"{a.Voornaam} {a.Naam}")
        .Where(n => n.Equals("Hugo Weaving", StringComparison.CurrentCultureIgnoreCase)).Count() > 0).ToList();

films_hugo_weaving =
    films.Where(f =>
        f.Rollen.Where(r => 
            r.Acteurs.Where(a => 
                a.Voornaam == "Hugo" && a.Naam == "Weaving"
            ).Count() > 0).Count() > 0).ToList();

// films uit de jaren '80 (1980-1989)
List<Film> films_80 = films.Where(f => f.Releasejaar >= 1980 && f.Releasejaar < 1990).ToList();

// filmreeksen met Peter Jackson als regisseur
List<Reeks> reeksen_Jackson = filmReeksen.Where
    (fr => fr.Films.Where(f => f.Regisseur.Equals("Peter Jackson", StringComparison.CurrentCultureIgnoreCase))
                    .Count() > 0)
    .ToList();

// acteurs die Bilbo Baggins speelden
List<Acteur> acteurs_bilbo = rollen.Where(r => r.Naam.Equals("Bilbo Baggins", StringComparison.CurrentCultureIgnoreCase))
                                .SelectMany(r => r.Acteurs).Distinct().ToList();

// titel (jaar) van films die niet beginnen met 'The'
List<string> films_zonder_the = films.Where(f => !f.Naam.StartsWith("The", StringComparison.CurrentCultureIgnoreCase))
                                     .Select(f => $"{f.Naam} ({f.Releasejaar})").ToList();
// films die in het begin van een decennium zijn uitgebracht
List<Film> films_begin_decennium = films.Where(f => f.Releasejaar % 10 == 0).ToList();

// titels van films met meer dan 2 rollen
List<string> titels_meer2rollen = films.Where(f => f.Rollen.Count > 2)
                                        .Select(f => f.Naam).ToList();

// acteurs wiens achternaam begint met een klinker
List<string> klinkers = new List<string>() { "A", "E", "U", "I", "O" };
List<Acteur> acteurs_klinker = acteurs.Where(a => klinkers.Contains(a.Naam.Substring(0, 1).ToUpper())).ToList();

// rollen met maar 1 naam (zonder voor- of achternaam)
List<string> rollen_1naam = rollen.Where(r => !r.Naam.Contains(" ")).Select(r => r.Naam).Distinct().ToList();


Console.WriteLine();
Console.WriteLine();