using DB_School_Databank;
using Microsoft.EntityFrameworkCore;

var db = new Connectie();

while (true)
{
    Console.WriteLine("Klassen: ");
    foreach (var klas in db.Klassen)
    {
        Console.WriteLine(klas.Naam);
    }

    Console.Write("Geef 0 in om een klas te maken of de naam van een klas om leerlingen toe te voegen: ");
    var invoer = Console.ReadLine();
    if (invoer == "0")
    {
        Console.Write("Naam: ");
        var naam = Console.ReadLine();
        var klas = new Klas();
        klas.Naam = naam;
        db.Klassen.Add(klas);
        db.SaveChanges();
    }
    else
    {
        var klasNaam = invoer;
        var klas = db.Klassen
            .Include(k => k.Leerlingen)
            .First(k => k.Naam == klasNaam);
        
        Console.WriteLine("Leerlingen:");
        foreach(var leerling in klas.Leerlingen)
        {
            Console.WriteLine($"{leerling.Voornaam} {leerling.Naam}");
        }


        Console.Write("Naam: ");
        var naam = Console.ReadLine();
        Console.Write("Voornaam: ");
        var voornaam = Console.ReadLine();
        var nieuweLeerling = new Leerling();
        nieuweLeerling.Naam = naam;
        nieuweLeerling.Voornaam = voornaam;
        klas.Leerlingen.Add(nieuweLeerling);
        db.SaveChanges();
    }
}

