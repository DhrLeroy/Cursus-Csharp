/*
Laat de gebruiker een lijst van getallen opgeven (tot de gebruiker 'stop' typt).
Maak vervolgens uit de lijst een nieuwe lijst van integers, waarbij elke waarde werd gekwadrateerd
Maak hiervoor gebruik van LINQ
Bv.

Getal: 1
Getal: 2
Getal: 3
Getal: 5
Getal: stop

Macht 1: 1
Macht 2: 4
Macht 3: 9
Macht 5: 25
 */

List<int> getallen = new List<int>();

var machten = getallen.Select(g => $"Macht {g}: {g * g}").ToList();

foreach (var macht in machten)
{
    Console.WriteLine(macht);
}