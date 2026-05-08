string[] letters = new string[] { "C", "A", "B", "D", "B", "U" };

Console.Write("Letter: ");
var letter = Console.ReadLine();

for(int i = 0; i < letters.Length; i++)
{
    if (letters[i] == letter)
    {
        Console.WriteLine($"Eerste positie van {letter} is {i}");
        return;
    }
}