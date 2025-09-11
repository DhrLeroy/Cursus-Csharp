List<int> getallen = new List<int>();
for (int i = 278; i <= 300; i++)
{
    getallen.Add(i);
}

var som = 0;

foreach (var getal in getallen)
    som += getal;

Console.WriteLine($"Som = {som}");