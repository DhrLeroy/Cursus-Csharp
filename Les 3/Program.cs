var lijst = new List<string>();

lijst.Add("B");
lijst.Add("C");
lijst.Add("D");

lijst.Insert(1,"A");

foreach(var x in lijst)
{
    Console.WriteLine(x);
}






































/*
int[] nummers = new int[3];

nummers[0] = 5;
nummers[1] = 6;
nummers[2] = 7;
Array.Resize(ref nummers, 4);

List<int> nummersList = new List<int>();
nummersList.Add(5);
nummersList.Add(6);
nummersList.Add(5);
nummersList.Remove(5);
nummersList.Insert(0, 4);
nummersList.RemoveAt(2);

Console.WriteLine("Overloop lijst nummers:");
foreach(int nummer in nummersList)
{
    Console.WriteLine(nummer);
}

Console.WriteLine("Getallen van 0 tot 3 (niet t.e.m.)");
for(int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("Getallen tot 5:");
for(int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine("Overloop array met for: ");
for(int i = 0; i < nummers.Length; i++)
{
    Console.WriteLine(nummers[i]);
}
Console.WriteLine("Overloop array met foreach:");
foreach(int getal in nummers)
{
    Console.WriteLine(getal);
}


Console.WriteLine();
*/



/*
var nummers = new List<int>() { 1, 2, 3 };

for(int positie = 0;  positie < nummers.Count; positie++)
{
    nummers[positie] += 2;
}



foreach(var nummer in nummers)
{
    Console.WriteLine(nummer);
}



*/














/*int[] nummers = new int[3];

nummers[0] = 1;
nummers[1] = 2;
nummers[2] = 3;


List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(1);
list.Remove(1);

foreach(var i in nummers)
{
    Console.WriteLine(i);
}

for(var i = 1; i <= 3; i++)
{
    Console.Write($"Geef getal {i} in: ");
    list.Add(Convert.ToInt32(Console.ReadLine()));
}

foreach(var i in list)
    { Console.WriteLine(i); }*/