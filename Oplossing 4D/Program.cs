Console.Write("Woord: ");

string woord = Console.ReadLine();

Console.Write("Gemaskeerd: ");

string sterretjes = "";
for (int i = 0; i < woord.Length - 2; i++)
{
    sterretjes += "*";
}

Console.Write($"{woord.Substring(0, 1).ToUpper()}{sterretjes}{woord.Substring(woord.Length - 1, 1).ToUpper()}");