/*var dierennamen = new List<string>();
var kleuren = new List<string>();
dierennamen.Add("Koala");
dierennamen.Add("Leeuw");
dierennamen.Add("Toekan");
kleuren.Add("grijs");
kleuren.Add("oranje");
kleuren.Add("kleurijk");
var aantal = new List<int>();
aantal.Add(3);
aantal.Add(10);
aantal.Add(2);
for (int i = 0; i < dierennamen.Count; i++)
{
    Console.WriteLine($"{dierennamen[i]} ({aantal[i]}): { kleuren[i]}");
}*/

/*var dierennamen = new List<string>();
var kleuren = new List<string>();
dierennamen.Add("Koala");
dierennamen.Add("Leeuw");
dierennamen.Add("Toekan");
kleuren.Add("kleurrijk");
kleuren.Add("grijs");
kleuren.Add("oranje");
for (int i = 0; i < dierennamen.Count; i++)
{
    Console.WriteLine($"{dierennamen[i]}: {kleuren[i]}");
}*/

/*var dierennamen = new List<string>();
var kleuren = new List<string>();
dierennamen.Add("Koala");
dierennamen.Add("Leeuw");
dierennamen.Add("Toekan");
kleuren.Add("grijs");
kleuren.Add("oranje");
kleuren.Add("kleurijk");
var indexenOranjeDieren = new List<int>();
for(int i = 0;i < kleuren.Count; i++)
{
    if(kleuren[i].Equals("oranje", StringComparison.CurrentCultureIgnoreCase))
        indexenOranjeDieren.Add(i);
}
foreach(var index in indexenOranjeDieren)
{
    Console.WriteLine(dierennamen[index]);
}*/


/*using OOP_VoorbeeldCursus;

var koala = new Dier("Koala", "grijs", "Zoogdier", true, 3, false);
koala.Naam = "Koala";
koala.Kleur = "grijs";
koala.Klasse = "Zoogdier";
koala.Is_herbivoor = true;
koala.Aantal_in_zoo = 3;
koala.Kan_vliegen = false;

var leeuw = new Dier("Leeuw", "oranje", "Zoogdier", false, 10, false);
leeuw.Naam = "Leeuw";
leeuw.Kleur = "oranje";
leeuw.Klasse = "Zoogdier";
leeuw.Is_herbivoor = false;
leeuw.Aantal_in_zoo = 10;
leeuw.Kan_vliegen = false;

var toekan = new Dier("Toekan", "kleurrijk", "Vogel", false, 2, true);
toekan.Naam = "Toekan";
toekan.Kleur = "kleurijk";
toekan.Klasse = "Vogel";
toekan.Is_herbivoor = false;
toekan.Aantal_in_zoo = 2;
toekan.Kan_vliegen = true;

List<Dier> dieren = new List<Dier>() { koala, leeuw, toekan };

foreach(var dier in dieren)
{
    Console.WriteLine($"{dier.Naam} ({dier.Aantal_in_zoo})");
}*/

using OOP_VoorbeeldCursus;

var koala = new Dier("Koala", "grijs", "Zoogdier", true, 3, false);

var leeuw = new Dier("Leeuw", "oranje", "Zoogdier", false, 10, false);

var toekan = new Dier("Toekan", "kleurrijk", "Vogel", false, 2, true);


