/*De gebruiker geeft een pizzaparty en wil pizza's bestellen. 
 Er is keuze tussen 2 pizzeria's. 
 Pizzeria Don Corleone heeft een standaardprijs, 12,50 euro per pizza. 
 Hij levert wel gratis. 
 Pizzeria Scaletta heeft een deal: per pizza betaal je 13 euro maar vanaf 20 pizza's krijg je 10 % korting. 
 Vanaf 50 pizza's krijg je 20 % korting. 
 Hij levert voor 0,80 euro per kilometer. 
 Maak een programma dat het aantal pizza's bevraagt, alsook de leverafstand. 
 Vervolgens bereken je de goedkoopste optie en geef je die aan de gebruiker. 
 Bv. 
 Aantal pizza: 25 
 Kilometer: 8 
 Beste optie: Pizzeria Don Corleone voor 312,5 euro.
 */

Console.Write("Aantal pizza: ");
var aantal = Convert.ToInt32(Console.ReadLine());
Console.Write("Kilometer: ");
var km = Convert.ToSingle(Console.ReadLine());

var scpizza = aantal * 13.0;
if (scpizza >= 50)
    scpizza = scpizza * 0.8;
else if (scpizza >= 20)
    scpizza = scpizza * 0.9;
scpizza = scpizza + km * 0.8;

var dcpizza = aantal * 12.5;

string beste_pizza = "";
var beste_prijs = 0.0;

if (scpizza > dcpizza)
{
    Console.WriteLine($"Beste optie: {}");
}