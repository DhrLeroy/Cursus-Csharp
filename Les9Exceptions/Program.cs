using Les9Exceptions;

var a = new A();
a.Do();




int getal = 0;

bool gelukt = Int32.TryParse(Console.ReadLine(),out getal);


/*bool doorgaan = false;
string user = "", pass="";

while (!doorgaan)
{
    try
    {
        doorgaan = true;    

        Console.Write("Gebruikersnaam: ");
        user = Console.ReadLine();

        if (user.ToLower() == user)
            throw new NoCapsException("Gebruikersnaam");
        else if (user.ToUpper() == user)
            throw new NoLowerCaseException("Gebruikersnaam");

        Console.Write("Wachtwoord: ");
        pass = Console.ReadLine();


        if (pass.ToLower() == pass)
            throw new NoCapsException("Wachtwoord");
        else if (pass.ToUpper() == user)
            throw new NoLowerCaseException("Wachtwoord");
    }
    catch (NoCapsException nce)
    {
        doorgaan =false;
        Console.WriteLine($"Je moet minstens één hoofdletter gebruiken: {nce.Message}");
    }
    catch (NoLowerCaseException nce)
    {
        doorgaan = false;
        Console.WriteLine($"Je moet minstens één kleine letter gebruiken: {nce.Message}");
    }
}
Console.WriteLine($"Inloggen met {user} (password: {pass})");

*/

/*var honden = new List<Hond>()
{
    new Hond("Waffie", 4),
    new Hond("Barko", 3),
    new Hond("Average", 2),
    new Hond("Waffie", 3)
};

Console.Write("Naam van de hond: ");
var naam = Console.ReadLine();

var hond = honden.FirstOrDefault(h => h.Naam == naam);
Console.WriteLine($"{naam} heeft {hond.AantalPoten} poten.");

*/


/*while (true)
{
    try
    {
        Console.Write("Getal 1: ");
        var g1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Getal 2: ");
        var g2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(g1 / g2);
    }
    catch(FormatException fe)
    {
        Console.WriteLine("Je moet gehele getallen opgeven.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Een van de getallen was te groot of te klein.");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Je kan niet delen door 0.");
    }
    catch (Exception)
    {
        Console.WriteLine("Er is iets fout gelopen.");
    }
}*/






























/*Console.Write("Geboortedatum: ");

var geboortedatum = DateTime.Parse(null);

if (2026 - geboortedatum.Year >= 18)
    Console.WriteLine("Meerderjarig");
else
    Console.WriteLine("Minderjarig");*/
/*
while (true)
{
    try
    {
        Console.Write("Teller: ");
        var teller = Convert.ToInt32(Console.ReadLine());

        Console.Write("Noemer: ");
        var noemer = Convert.ToInt32(Console.ReadLine());

        var quotient = teller / noemer;

        Console.WriteLine(quotient);
    }
    catch (FormatException)
    {
        Console.WriteLine("Je moet de getallen in cijfers opgeven.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Het getal dat je opgaf was te groot of te klein.");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Je kan niet delen door 0.");
    }
}


*/
/*
using Les9Exceptions;

try
{
    var a = new A();
    a.Do();
}
catch
{
    Console.WriteLine("Er is ergens iets foutgelopen.");
}*/

