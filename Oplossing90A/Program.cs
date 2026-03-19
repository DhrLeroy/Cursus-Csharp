List<string> fruit = new List<string>();

for(int i = 0; i < 5; i++)
{
    Console.Write("Fruitsoort: ");
    fruit.Add(Console.ReadLine());
}

var letters = new List<string>() { "A", "B", "C", "D", "E" };

foreach(var letter in letters)
{
    try
    {
        var fruitnaam = fruit.First(f => f.StartsWith(letter, StringComparison.CurrentCultureIgnoreCase));
        Console.WriteLine($"{letter}: {fruitnaam}");
    }
    catch (InvalidOperationException)
    {
        Console.WriteLine($"Er is geen fruitsoort ingegeven, beginnend met {letter}");
    }
}