using Oefening7InleidingMuziekgroep___Oplossing;

var muziekgroepen = new List<Muziekgroep>();

muziekgroepen.Add(new Muziekgroep("Iron Maiden", "Heavy Metal", 17, 1975));
muziekgroepen.Add(new Muziekgroep("Metallica", "Heavy Metal", 11, 1981));
muziekgroepen.Add(new Muziekgroep("Spandau Ballet", "New Wave", 7, 1976));

foreach (var groep in muziekgroepen)
{
    Console.WriteLine($"{groep.Naam} speelt {groep.Genre} en bracht al {groep.Aantal_albums} albums uit.");
}