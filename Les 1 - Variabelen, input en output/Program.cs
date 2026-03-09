/*Console.Write("Naam: ");
var naam = Console.ReadLine();

Console.WriteLine("Hallo " + naam);

Console.Write("Hoe oud ben je? ");

var leeftijd = Console.ReadLine();

var x = Convert.ToInt32(leeftijd) + 1;


Console.WriteLine("Je wordt " + x + " jaar oud.");


var grootte = 1.62;*/

/*Console.Write("Getal x: ");
var x = Convert.ToInt32(Console.ReadLine());*/

/*Console.Write("Getal b: ");
var b = Convert.ToDouble(Console.ReadLine());

var som = a + b;
Console.WriteLine($"De som is {som}");

var verschil = a - b;
Console.WriteLine($"De verschil is {verschil}");

var product = a * b;
Console.WriteLine($"De product is {product}");

var quotient = a / b;
Console.WriteLine($"De quotient is {quotient}");

var modulo = a % b;
Console.WriteLine($"De modulo is {modulo}");*/

//var formule = (3 * Math.Pow(x, 6)) + (Math.Pow(x, 2) * 1 / (4 * x)) - 5;

/*string input = "";
int som = 0;
int teller = 0;
while (input != "stop")
{
    Console.Write("Score: ");
    input = Console.ReadLine();
    if (input.ToLower() != "stop")
    {
        try
        {
            int score = Convert.ToInt32(input);
            som += score;
            teller++;
        }
        catch (FormatException)
        {
            Console.WriteLine("Het getal was niet in het correcte formaat.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Het getal is te groot of te klein.");
        }
    }
}
try
{
    Console.WriteLine($"Het gemiddelde is {som/teller}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Er zijn geen scores ingevoerd, dus het gemiddelde kan niet worden berekend.");
}

*/
while (true)
{
    try
    {
        Console.Write("Oud wachtwoord: ");
        var oudWachtwoord = Console.ReadLine();
        Console.Write("Nieuw wachtwoord: ");
        var nieuwWachtwoord = Console.ReadLine();
        if (oudWachtwoord == nieuwWachtwoord)
            throw new Exception("Het nieuwe wachtwoord mag niet hetzelfde zijn als het oude wachtwoord.");
        Console.Write("Geef het nieuwe wachtwoord opnieuw in: ");
        var nieuwWachtwoord2 = Console.ReadLine();
        if (nieuwWachtwoord != nieuwWachtwoord2)
            throw new Exception("De nieuwe wachtwoorden komen niet overeen.");
        if (nieuwWachtwoord.ToLower() == nieuwWachtwoord)
            throw new Exception("Het nieuwe wachtwoord bevat geen hoofdletters.");
        if (nieuwWachtwoord.ToUpper() == nieuwWachtwoord)
            throw new Exception("Het nieuwe wachtwoord bevat geen kleine letters.");
        Console.WriteLine("Wachtwoord succesvol ingesteld.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wachtwoord niet ingesteld: {ex.Message}");
    }
}
try
{
    Console.Write("Oud wachtwoord: ");
    var oudWachtwoord = Console.ReadLine();
    Console.WriteLine("Nieuw wachtwoord: ");
    var nieuwWachtwoord = Console.ReadLine();
    if(oudWachtwoord == nieuwWachtwoord)
        throw new Exception("Het nieuwe wachtwoord mag niet hetzelfde zijn als het oude wachtwoord.");
    Console.Write("Geef het nieuwe wachtwoord opnieuw in: ");
    var nieuwWachtwoord2 = Console.ReadLine();
    if(nieuwWachtwoord != nieuwWachtwoord2)
        throw new Exception("De nieuwe wachtwoorden komen niet overeen.");
    if (nieuwWachtwoord.ToLower() == nieuwWachtwoord)
        throw new Exception("Het nieuwe wachtwoord bevat geen hoofdletters.");
    if (nieuwWachtwoord.ToUpper() == nieuwWachtwoord)
        throw new Exception("Het nieuwe wachtwoord bevat geen kleine letters.");
}
catch (Exception ex)
{
    Console.WriteLine($"Wachtwoord niet ingesteld: {ex.Message}");
}












































/*Console.Write("Geef je naam in: ");
var naam = Console.ReadLine();

Console.WriteLine($"Hallo {naam}");

//   cw + Tab    :    Console.WriteLine();

//  tijdens typen Ctrl+spatie     : aanvullen

Console.Write("");*/

//System.Console.WriteLine(3+8*0.5);


