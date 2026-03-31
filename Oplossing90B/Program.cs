
while (true)
{
    try
    {
        Console.Write("Gewicht (kg): ");
        var g = Convert.ToSingle(Console.ReadLine());
        if (g > 400)
            throw new Exception("Gewicht kan niet groter zijn dan 400 kg.");
        if (g < 0)
            throw new Exception("Gewicht kan niet negatief zijn");
        Console.Write("Lengte (m): ");
        var l = Convert.ToSingle(Console.ReadLine());
        if (l < 0.5)
            throw new Exception("Lengte kan niet kleiner zijn dan 0,5m");
        var bmi = g / (l * l);
        Console.WriteLine($"BMI = {bmi}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Gelieve een kommagetal in te geven.");
    }
    catch (OverflowException oex)
    {
        Console.WriteLine("Het getal was te groot of te klein");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
