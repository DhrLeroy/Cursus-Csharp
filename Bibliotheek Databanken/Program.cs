using Bibliotheek_Databanken;
using Microsoft.EntityFrameworkCore;

var db = new Connectie();


while (true)
{
    Console.WriteLine("Auteurs (geef 0 in om een nieuwe in te geven, of de Id om de boeken te bekijken): ");
    foreach (var auteur in db.Auteurs)
    {
        Console.WriteLine($"{auteur.Id}: {auteur.Voornaam} {auteur.Naam}");
    }

    var id = Convert.ToInt32(Console.ReadLine());
    if (id == 0)
    {
        Console.Write("Voornaam: ");
        var vn = Console.ReadLine();
        Console.Write("Naam: ");
        var n = Console.ReadLine();
        var auteur = new Auteur();
        auteur.Voornaam = vn;
        auteur.Naam = n;
        db.Auteurs.Add(auteur);
        db.SaveChanges();
    }
    else
    {
        var auteur = db.Auteurs.Include(a => a.Boeken).First(a => a.Id == id);
        Console.WriteLine("Boeken: ");
        foreach (var boek in auteur.Boeken)
        {
            Console.WriteLine($"{boek.Titel} ({boek.Genre}, {boek.Aantal_paginas} pagina's)");
        }
        Console.Write("Geef 0 in om een nieuw boek toe te voegen: ");
        if (Console.ReadLine() == "0")
        {
            Console.Write("Titel: ");
            var t = Console.ReadLine();
            Console.Write("Genre ");
            var g = Console.ReadLine();
            Console.Write("Aantal pagina's: ");
            var p = Convert.ToInt32(Console.ReadLine());
            var boek = new Boek();
            boek.Titel = t;
            boek.Genre = g;
            boek.Aantal_paginas = p;
            boek.Auteur = auteur;
            auteur.Boeken.Add(boek);
            db.SaveChanges();
        }
    }
}
