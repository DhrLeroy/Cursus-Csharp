Console.Write("Getal 1: ");
var getal1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Getal 2: ");
var getal2 = Convert.ToInt32(Console.ReadLine());

var kleinste = (new int[] { getal1, getal2 }).Min();

var ggd = kleinste;

for(int deler = kleinste; deler >= 1; deler--)
{
    if (getal1 % deler == 0 && getal2 % deler == 0)
    {
        ggd = deler;
        break;
    }

}

Console.WriteLine($"GGD van {getal1} en {getal2} is {ggd}");