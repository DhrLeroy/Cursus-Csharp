﻿using Klassen;

List<Leerling> leerlingen = new List<Leerling>();

Toets wiskunde_cirkel = new Toets();
wiskunde_cirkel.Naam = "Eigenschappen van een cirkel";
wiskunde_cirkel.VulScoreIn(20);

/*for(int i = 0; i < 2; i++)
{
    Leerling l = new Leerling();
    Console.Write("Naam: ");
    l.Voornaam = Console.ReadLine();
    Console.Write("Leeftijd: ");
    l.Leeftijd = Convert.ToInt32(Console.ReadLine());
    leerlingen.Add(l);
}*/




var leerling1 = new Leerling("Muppet", "Bert", 65);
leerlingen.Add(leerling1);

var leerling2 = new Leerling("Muppet", "Ernie", 55);
leerlingen.Add(leerling2);


foreach (var leerling in leerlingen)
{
    Console.WriteLine($"{leerling.Voornaam}: {leerling.Leeftijd} jaar");
}
