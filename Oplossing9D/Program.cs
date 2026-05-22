using Oplossing9D;

var pokemons = new List<Pokémon>();

try
{
    for(int i = 0; i < 3; i++)
    {
        Console.Write("Naam: ");
        var naam = Console.ReadLine();
        Console.Write("Type: ");
        var type = Console.ReadLine();
        Console.Write("HP: ");
        var hp = Convert.ToInt32(Console.ReadLine());

        var nieuwe_pokemon = new Pokémon(naam, type, hp);
        pokemons.Add(nieuwe_pokemon);
    }
    Console.Write("Naam: ");
    var gezocht = Console.ReadLine();

    var pokemon = pokemons.Single(p => p.Naam.Equals(gezocht, StringComparison.CurrentCultureIgnoreCase));
}
catch (FormatException)
{
    Console.WriteLine("Gelieve een geldig geheel getal als HP in te geven.");
}
catch(OverflowException)
{
    Console.WriteLine($"Gelieve een geheel getal als HP tussen {Int32.MinValue} en {Int32.MaxValue} in te geven.");
}

try
{
    Console.Write("Positie: ");
    var positie = Convert.ToInt32(Console.ReadLine());

    // corrigeer met -1 voor gebruiksvriendelijkheid. 1 = Eerste Pokémon maar staat op positie 0 in de lijst
    var pokemon = pokemons[positie-1];
}
catch (FormatException)
{
    Console.WriteLine("Gelieve een geldig geheel getal als positie in te geven.");
}
catch (OverflowException)
{
    Console.WriteLine($"Gelieve een geheel getal als positie tussen {Int32.MinValue} en {Int32.MaxValue} in te geven.");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine($"Gelieve een positie tussen 1 en {pokemons.Count} op te geven.");
}
