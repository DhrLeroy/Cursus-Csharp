using Oefening7InleidingPuzzel___Oplossing;

var puzzels = new List<Puzzel>();
puzzels.Add(new Puzzel("Ravensburger", "2 poezen op een kussentje", 100, 5));
puzzels.Add(new Puzzel("Clementoni", "Stranger Things", 1000, 7));
puzzels.Add(new Puzzel("Ravensburger", "De Toren van Babel", 5000, 129.99));

foreach (var puzzel in puzzels)
{
    Console.WriteLine($"Puzzel van {puzzel.Beschrijving} kost {puzzel.Prijs} euro.");
}