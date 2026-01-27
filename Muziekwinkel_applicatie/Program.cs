using Muziekwinkel_databank;

List<Artiest> artiesten = new List<Artiest>();

Artiest a1 = new Artiest();
a1.Naam = "Taylor Swift";
a1.Genre = "Pop";
artiesten.Add(a1);

var a2 = new Artiest();
a2.Naam = "Jim Morrison";
a2.Genre = "Rock";
artiesten.Add(a2);

foreach (var a in artiesten)
{
    Console.WriteLine($"{a.Naam} speelt {a.Genre}");
}
        
