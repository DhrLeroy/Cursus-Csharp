using Herhaling_Examen_2_5ICW___2024_2025___Oefening_3;

var personen = new List<Persoon>()
{
    new Persoon("Max", "Verstappen", 1997, 9, 30),
    new Persoon("Andrea Kimi", "Antonelli", 2006, 8, 25),
    new Persoon("Lando", "Norris", 1999, 11, 13),
    new Persoon("Jean-Marie", "Jamal", 2000, 2, 29)
};


foreach(var persoon in personen)
{
    Console.WriteLine($"{persoon.Voornaam} {persoon.Naam} is {persoon.BerekenLeeftijd()} jaar.");
}