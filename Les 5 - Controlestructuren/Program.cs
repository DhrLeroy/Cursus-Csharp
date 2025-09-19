/*Console.Write("Getal: ");

var getal = Convert.ToInt32(Console.ReadLine()); 

if (getal > 0)
    Console.WriteLine("+");
else if(getal < 0)
    Console.WriteLine("-");
else
    Console.WriteLine("allebei ");
*/

string email = Console.ReadLine();
if (!email.Contains("@"))
{
 Console.WriteLine("Geen @-teken");
}



string password = "ABC";
string input = "";

do
{
    Console.Write("Wachtwoord: ");
    input = Console.ReadLine();
} while (password != input);

Console.WriteLine($"Ingelogd");