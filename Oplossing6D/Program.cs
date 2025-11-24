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


// filmreeksen met Peter Jackson als regisseur


// acteurs die Bilbo Baggins speelden


// titel (jaar) van films die niet beginnen met 'The'


// films die in het begin van een decennium zijn uitgebracht


// titels van films met meer dan 2 rollen


// acteurs wiens achternaam begint met een klinker


// rollen met maar 1 naam (zonder voor- of achternaam)


// filmrollen die

Console.WriteLine();
Console.WriteLine();