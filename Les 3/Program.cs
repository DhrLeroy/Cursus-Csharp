int[] nummers = new int[3];

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
    { Console.WriteLine(i); }