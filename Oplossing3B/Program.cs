List<int> getallen = new List<int>();
for (var i = 0; i < 3; i++)
{
    Console.Write("Geef een getal in: ");
    getallen.Add(Convert.ToInt32(Console.ReadLine()));
}

int som = 0;
foreach (var getal in getallen)
{
    som = som + getal;  // kan ook worden geschreven als som += getal
}
Console.WriteLine($"Som = {som}");
// kan ook me getallen.Sum()