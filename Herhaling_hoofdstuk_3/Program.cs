/*List<string> alfabet1 = new List<string>();
alfabet1.Add("A");
alfabet1.Add("B");
alfabet1.Add("C");
alfabet1.Add("D");
alfabet1.Add("E");
// i = 0    :   i begint vanaf 0
// i < alfabet.Count     :     zolang i kleiner is dan de lengte van alfabet1
// i++     :     verhoog i met 1 (i+1)

for(int i = 0; i < alfabet1.Count; i++)
{
    if (alfabet1[i] == "A")
        alfabet1[i] = "";
    Console.WriteLine(alfabet1[i]);
}

foreach(string letter in alfabet1)
{
    if (letter == "A")
        alfabet1.Remove(letter);
}

string[] alfabet2 = new string[4];
alfabet2[0] = "A";
alfabet2[1] = "B";
alfabet2[2] = "C";
alfabet2[3] = "D";

alfabet2[2] = "";*/

/*

int[] getallen = new int[10];
for(int i = 0; i< getallen.Length; i++)
{
    Console.Write($"Geef getal {i + 1}: ");
    int getal = Convert.ToInt32(Console.ReadLine());
    getallen[i] = getal;
}

for(int i = 0; i <  getallen.Length; i++)
{
    if (getallen[i] % 2 == 0)
        getallen[i] = 0;
}

foreach(var getal in getallen)
{
    Console.WriteLine(getal);
}*/

using Herhaling_hoofdstuk_3;

List<Persoon> personen = new List<Persoon>();
personen.Add(new Persoon(17, "Jack"));
personen.Add(new Persoon(20, "Ellie"));

/*
 * WERKT NIET
 * 
 * foreach(var persoon in personen)
{
    if (persoon.Leeftijd < 18)
        personen.Remove(persoon);
}*/

for(int positie = 0;  positie < personen.Count; positie++)
{
    if(personen[positie].Leeftijd < 18)
    {
        personen.Remove(personen[positie]);
    }
}

foreach(var p in personen)
{
    Console.WriteLine(p.Naam);
}