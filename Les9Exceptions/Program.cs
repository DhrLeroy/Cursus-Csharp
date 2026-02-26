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

using Les9Exceptions;

try
{
    var a = new A();
    a.Do();
}
catch
{
    Console.WriteLine("Er is ergens iets foutgelopen.");
}

