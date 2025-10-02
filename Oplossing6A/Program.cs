List<int> getallen = new List<int>();

var machten = getallen.Select(g => $"Macht {g}: {g * g}").ToList();

foreach(var macht in machten)
{
    Console.WriteLine(macht);
}