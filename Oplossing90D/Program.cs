using System.Diagnostics;

Console.WriteLine("Geef de coëfficiënten op van de vergelijking ax²+bx+c = 0");

var coefficienten = new int[3];
var coefficienten_namen = new string[3] {"a","b","c"};

var nulwaardes = new List<double>();

for (int i = 0; i < coefficienten.Length; i++)
{
    while (true)
    {
        try
        {
            Console.Write($"{coefficienten_namen[i]}: ");
            coefficienten[i] = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Geef een geldige waarde in.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Het getal was te groot of te klein");
        }
    }
}

try
{
    if (coefficienten[0] == 0)
        throw new Exception("Geen tweedegraadsvergelijking!");
    var d = Math.Pow(coefficienten[1], 2) - 4 * coefficienten[0] * coefficienten[2];
    var x1 = (-coefficienten[1]+Math.Sqrt(d)) / (2 * coefficienten[0]);
    var x2 = (-coefficienten[1] - Math.Sqrt(d)) / (2 * coefficienten[0]);
    nulwaardes.Add(x1);
    nulwaardes.Add(x2);
}
catch(Exception e)
{
    try
    {
        Console.WriteLine(e.Message);
        if (coefficienten[1] == 0)
            throw new Exception("Geen eerstegraadsvergelijking!");
        nulwaardes.Add(-coefficienten[2] / coefficienten[1]);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
        if (coefficienten[2] == 0)
        {
            nulwaardes.Add(double.NegativeInfinity);
            nulwaardes.Add(double.PositiveInfinity);
        }
    }
}

Console.WriteLine($"Nulwaardes voor {coefficienten[0]}x² + {coefficienten[1]}x + {coefficienten[2]} zijn {(nulwaardes.Contains(double.NegativeInfinity) && nulwaardes.Contains(double.PositiveInfinity) ? "Alle reële getallen" : string.Join(", ", nulwaardes))}");

