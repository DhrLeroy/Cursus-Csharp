List<string> ingredienten = new List<string>();
for (int i = 0; i < 3; i++)
{
    Console.Write("Geef een ingrediënt: ");
    ingredienten.Add(Console.ReadLine());
}

for (int i = 0; i < ingredienten.Count; i++)
{
    ingredienten[i] = $"{i + 1}. {ingredienten[i]}";
}

foreach (var i in ingredienten)
{
    Console.WriteLine(i);
}