using Oplossing9C;

var gezocht = "";

try
{
    var pokemons = new List<Pokémon>();

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
    gezocht = Console.ReadLine();

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
catch (InvalidOperationException)
{
    Console.WriteLine($"Er werden geen of meerdere Pokémons gevonden met de naam '{gezocht}'.");
}