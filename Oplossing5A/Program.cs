bool gevalideerd;
do
{
    gevalideerd = true;
    Console.Write("E-mailadres: ");
    var email = Console.ReadLine();
    if (!email.Contains("@"))
    {
        gevalideerd = false;
        Console.WriteLine("Geen @-teken in het e-mailadres");
    }
    var liodot = email.LastIndexOf(".");
    if (liodot > email.Length - 3 || liodot < 0 || liodot < email.LastIndexOf("@"))
    {
        gevalideerd = false;
        Console.WriteLine("E-mailadres heeft geen geldig einde");
    }
} while (!gevalideerd);

Console.WriteLine("E-mailadres gevalideerd");