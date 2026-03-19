using System.Diagnostics;

Console.WriteLine("Geef de coëfficiënten op van de vergelijking ax²+bx+c = 0");

var coefficienten = new int[3];
var coefficienten_namen = new string[3] {"a","b","c"};

for (int i = 0; i < coefficienten.Length; i++)
{
    while ()
    {
        try
        {
            Console.Write($"{coefficienten_namen[i]}: ");
            coefficienten[i] = Convert.ToInt32(Console.ReadLine());
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

Console.WriteLine($"Nulpunten voor {coefficienten[0]}x² + {coefficienten[1]}x + {coefficienten[2]} = 0");

