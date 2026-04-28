/*List<int> getallen = new List<int>();

while(getallen.Contains(0) == false)
{
    Console.Write("Getal: ");
    var getal = Convert.ToInt32(Console.ReadLine());
    getallen.Add(getal);
}*/

int bedrag = 0;
while(bedrag <= 0)
{
    Console.Write("Bedrag: ");
    bedrag = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Bedrag is {bedrag}");

/*Console.Write("Getal: ");

var getal = Convert.ToInt32(Console.ReadLine()); 

if (getal > 0)
    Console.WriteLine("+");
else if(getal < 0)
    Console.WriteLine("-");
else
    Console.WriteLine("allebei ");
*/

/*string email = Console.ReadLine();
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

Console.WriteLine($"Ingelogd");*/