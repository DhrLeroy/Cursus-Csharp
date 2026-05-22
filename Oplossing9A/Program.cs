try
{
    Console.Write("Geboortejaar: ");
    var jaar = Convert.ToInt32(Console.ReadLine());
    Console.Write("Geboortemaand: ");
    var maand = Convert.ToInt32(Console.ReadLine());
    Console.Write("Geboortedag: ");
    var dag = Convert.ToInt32(Console.ReadLine());

    var geboortedatum = new DateTime(jaar, maand, dag);

    if (geboortedatum > DateTime.Today)
        throw new Exception("De geboortedatum mag niet in de toekomst liggen.");
    if (geboortedatum < new DateTime(1900, 1, 1))
        throw new Exception("Geboortedatum mag niet kleiner zijn dan 1 januari 1900");
}
catch(FormatException)
{
    Console.WriteLine("De dag, maand of jaartal dienen als getal te worden opgegeven.");
}
catch (OverflowException)
{
    Console.WriteLine($"De dag, maand of jaartal dienen binnen het bereik {Int32.MinValue} en {Int32.MaxValue} te liggen.");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("De combinatie van dag, maand en jaartal was niet geldig");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
