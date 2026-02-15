using Oefening7InleidingFilm___Oplossing;

var films = new List<Film>();
films.Add(new Film("The Shawshank Redemption", "Frank Darabont", 1994, 9.3));
films.Add(new Film("The Godfather", "Francis Ford Coppola", 1972, 9.2));
films.Add(new Film("The Dark Knight", "Christopher Nolan", 2008, 9.0));

foreach (var film in films)
{
    var aanrader = "";
    if(film.Rating_op_10 >= 9.0)
    {
        aanrader = " AANRADER!!!";
    }
    Console.WriteLine($"{film.Titel} ({film.Genre}) duurt {film.Duurtijd_in_minuten / 60.0} uur.{aanrader}");
}