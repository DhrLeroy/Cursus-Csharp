/*
Maak een programma dat een e-mailadres aan een gebruiker vraagt ("E-mailadres: ").
Als het e-mailadres geen @-teken bevat, toon de foutboodschap: "Geen @-teken in het e-mailadres". 
Een e-mailadres moet ook eindigen met een punt en dan 2 of 3 tekens erna. 
Als dit niet het geval is, toon je de boodschap: "E-mailadres heeft geen geldig einde". 
Als alles goed is, toon je: "E-mailadres gevalideerd".
Zolang het e-mailadres niet is gevalideerd, vraag je dit opnieuw.
 */

bool gevalideerd = false;

do
{
    gevalideerd = true;
    Console.Write("E-mailadres: ");
    string email = Console.ReadLine();
    if (!email.Contains("@"))
    {
        Console.WriteLine("Geen @-teken in het e-mailadres");
        gevalideerd = false;
    }
    if(email.LastIndexOf(".") > email.Length - 4)
    {
        Console.WriteLine("E-mailadres heeft geen geldig einde");
        gevalideerd = false;
    }
} while (!gevalideerd);

Console.WriteLine("E-mailadres gevalideerd");

