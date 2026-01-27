using Muziekwinkel_databank;

var db = new Databank();

foreach (var art in db.Artiesten)
{
    Console.WriteLine($"{art.artiestid}: {art.Voornaam} {art.Naam} ({art.Genre})");
}

Console.Write("Geef de Id in van een artiest om die te verwijderen (0 = niets verwijderen): ");
var id = Convert.ToInt32(Console.ReadLine());

if(id > 0)
{
    Artiest artiest = db.Artiesten.Where(a => a.artiestid == id).First();
    db.Artiesten.Remove(artiest);
    db.SaveChanges();
}

Console.Write("Geef de Id in van een artiest om het genre te wijzigen (0 = niets wijzigen): ");
id = Convert.ToInt32(Console.ReadLine());
if (id > 0)
{
    Console.Write("Nieuw genre: ");
    var nieuw_genre = Console.ReadLine();
    Artiest artiest = db.Artiesten.Where(a => a.artiestid == id).First();
    artiest.Genre = nieuw_genre;
    db.SaveChanges();
}

Console.Write("Naam: ");
var naam = Console.ReadLine();

Console.Write("Voornaam: ");
var voornaam = Console.ReadLine();

Console.Write("Genre: ");
var genre = Console.ReadLine();

var a1 = new Artiest(naam, voornaam, genre);

db.Artiesten.Add(a1);
db.SaveChanges();