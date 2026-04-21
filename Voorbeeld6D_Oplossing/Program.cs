using Films.Classes;
using Films.Data;

List<Reeks> reeksen = Data.GetData();

// titels van de reeksen

var titels_reeksen = reeksen.Select(r => r.Naam).ToList();

// gemiddelde lengte van de naam van een reeks

var gemiddelde_lengte_reeks_titel =
    titels_reeksen.Average(t => t.Length);

// kortste titel van een reeks

var lengte_kortste_titel_reeks = titels_reeksen.Min(t => t.Length);
var kortste_titel_reeks = titels_reeksen
    .Where(t => t.Length == lengte_kortste_titel_reeks)
    .ToList();

// zijn er titels met het woord "The" ?

var bestaan_titels_met_woord_the =
    titels_reeksen.Any(t => t.Replace(":","")
                            .Split(" ")
                            .Any(w => w.
                                   Equals("the", StringComparison.CurrentCultureIgnoreCase)
                            )
                       );

// bevatten alle titels het woord the
var hebben_alle_titels_woord_the =
    titels_reeksen.All(t => t.Replace(":", "")
                            .Split(" ")
                            .Any(w => w.
                                   Equals("the", StringComparison.CurrentCultureIgnoreCase)
                            )
                       );

//alle films

var alle_films = reeksen.SelectMany(r => r.Films).Distinct().ToList();

// titels van alle films

var titels_films = alle_films.Select(f => f.Naam).ToList();

// alle films uit de 21e eeuw

var films_21e_eeuw = alle_films.Where(f => f.Releasejaar >= 2001 && 
                                           f.Releasejaar <= 2100).ToList();
// alle films van The Matrix

var films_van_reeks_the_matrix = reeksen
    .Where(t => t.Naam.Equals("The Matrix", StringComparison.CurrentCultureIgnoreCase))
    .SelectMany(r => r.Films).ToList(); ;

// alle films van The Matrix uit de 21e eeuw

var films_the_matrix_21e_eeuw = films_21e_eeuw.Intersect(films_van_reeks_the_matrix);

// alle films met Hugo Weaving

var films_hugo_weaving = alle_films.Where(
    f => f.Rollen.Any(r
        => r.Acteurs.Any(a => a.Naam.Equals("Weaving", StringComparison.CurrentCultureIgnoreCase)
                              && a.Voornaam.Equals("Hugo", StringComparison.CurrentCultureIgnoreCase)
                        )
        )
    ).ToList();

// alle films van George Lucas

var films_george_lucas = alle_films
    .Where(f => f.Regisseur.Equals("George Lucas", StringComparison.CurrentCultureIgnoreCase))
    .ToList();

// films in een het begin van een decennium

var films_begin_decennium = alle_films.
    Where(f => f.Releasejaar % 10 == 0).ToList();

// alle films van George Lucas die NIET zijn uitgekomen in het begin van een decennium

var films_george_lucas_niet_begin_decennium = films_george_lucas.Except(films_begin_decennium);

// alle films van Peter Jackson

var films_peter_jackson = alle_films
    .Where(f => f.Regisseur.Equals("Peter Jackson", StringComparison.CurrentCultureIgnoreCase))
    .ToList();

// alle films van Peter Jackson of George Lucas

var films_peterJackson_of_georgeLucas =
    films_george_lucas.Concat(films_peter_jackson);

// alle films gesorteerd op jaar van uitgave, van meest naar minst recent

var films_volgens_jaar_uitgave = alle_films.OrderByDescending(f => f.Releasejaar).ToList();

// alle films gesorteerd op jaar van uitgave, van meest naar minst recent, vervolgens alfabetisch A-Z

var films_volgens_uitgave_dan_alfabetisch =
    alle_films.OrderByDescending(f => f.Releasejaar)
    .ThenBy(f => f.Naam).ToList();

// alle films uit de 21e eeuw, gesorteerd op het aantal rollen (groot naar klein)

var films_21_eeuw_volgend_aantal_rollen =
    films_21e_eeuw.OrderByDescending(f => f.Rollen.Count).ToList();

// alle films uit alle andere eeuwen

var films_vorige_eeuwen = alle_films.Except(films_21e_eeuw);


// alle films per regisseur, gesorteerd op regisseur

var films_per_regisseur = alle_films.GroupBy(f => f.Regisseur)
                                    .OrderBy(groep => groep.Key)
                                    .ToList();

foreach(var groep in films_per_regisseur)
{
    Console.WriteLine($"{groep.Key}: {string.Join(", ", groep
                            .OrderBy(f => f.Releasejaar)
                            .Select(f => $"{f.Naam} ({f.Releasejaar})"))}");
}

// titels van alle films volgens eerste beginletter, tenzij het begint met The

var films_volgens_eerste_letter = alle_films.Select(f => f.Naam)
    .Select(t => t.StartsWith("The ", StringComparison.CurrentCultureIgnoreCase) ? t.Substring(4) : t)
    .GroupBy(t => t.Substring(0, 1))
    .ToList();



Console.WriteLine();
Console.WriteLine();