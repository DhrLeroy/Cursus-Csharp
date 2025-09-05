List<int> getallen = new List<int>();
for (var i = 1; i <= 5; i++)
{
    Console.Write("Geef een getal in: ");
    var getal = Convert.ToInt32(Console.ReadLine());
    getallen.Add(getal);
}
foreach (var getal in getallen)
{
    Console.WriteLine(getal);
}