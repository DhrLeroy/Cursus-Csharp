using Oefening7InleidingLeerling___Oplossing;

var leerlingen = new List<Leerling>();

leerlingen.Add(new Leerling("Jan", "Janssens", 15, "5ICW"));
leerlingen.Add(new Leerling("Piet", "Pieters", 16, "5ICW"));
leerlingen.Add(new Leerling("Klaas", "Klaassen", 14, "4TW"));

foreach (var leerling in leerlingen)
{
    Console.WriteLine($"{leerling.Voornaam} {leerling.Naam.ToUpper()} ({leerling.Klas}) is {leerling.Leeftijd} jaar oud.");
}