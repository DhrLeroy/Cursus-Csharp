int nummer = 3;

bool waar = true;

if (nummer > 0)
{
    Console.WriteLine("positief");
}



string tekst = "abc";

if (tekst.Contains("b"))
{
    Console.WriteLine("bevat b");
}

if(tekst.StartsWith("A", StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine("begint met A");
}
if (tekst.EndsWith("C", StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine("eindigt met C");
}






string wachtwoord = "MyVerySecurePassword123!";
string input="";
do
{
    Console.Write("Geef het wachtwoord in: ");
    input = Console.ReadLine();
} while (wachtwoord != input);
