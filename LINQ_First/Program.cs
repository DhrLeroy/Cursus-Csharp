/*List<String> getallen = new List<String> {};

var eerste = getallen.Single();

Console.WriteLine();

Console.ReadLine();

//Console.WriteLine(getallen.First(g => g > 2));
*/

using LINQ_First;

List<Film> films = new List<Film>()
{
    new Film("A", 1),
    new Film("B", 2),
    new Film("B", 3),
    new Film("D", 4),
    new Film("E", 5)
};

Console.Write("Titel: ");
var t = Console.ReadLine();
/*try
{
    Console.WriteLine(films.Single(f => f.Titel == t).Duurtijd_min);

}
catch (InvalidOperationException)
{
    var t_films = films.Where(f => f.Titel == t).ToList();
    foreach(var f in t_films)
    {
        Console.WriteLine(f.Duurtijd_min);
    }
}*/

Film f = films.FirstOrDefault(fi => fi.Duurtijd_min == 90);

Console.WriteLine(films.First(film => film.Titel == f.Titel));



