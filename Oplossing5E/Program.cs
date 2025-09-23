/*  Bij een pittazaak kost een pitta 5 euro. Vanaf 20 euro wordt er gratis geleverd.
    Een levering kost 3 euro.
    Bevraag het aantal dat men wenst te bestellen ("Aantal: ")
    Bereken vervolgens het totaal.
    Blijf opnieuw vragen naar een aantal zolang de gebruiker geen positief getal (groter dan 0) ingeeft.

Bv.

Aantal: 3
Totaal: 18 euro

Aantal: 4
Totaal: 20 euro

Aantal: 5
Totaal: 25 euro

Aantal: -2
Aantal: 0
Aantal: 2
Totaal: 13 euro
 */

var aantal = 0;
var prijs = 0;
do
{
    Console.Write("Aantal: ");
    aantal = Convert.ToInt32(Console.ReadLine());
    prijs = aantal * 5 + (aantal >= 4 ? 0 : 3);
} while (aantal < 1);
Console.WriteLine($"Totaal: {prijs} euro");