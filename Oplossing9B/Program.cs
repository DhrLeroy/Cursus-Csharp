try
{
    Console.Write("Zijde A: ");
    var a = Convert.ToSingle(Console.ReadLine());
    Console.Write("Zijde B: ");
    var b = Convert.ToSingle(Console.ReadLine());
    Console.Write("Zijde C: ");
    var c = Convert.ToSingle(Console.ReadLine());
    Console.Write("Hoek ingesloten tussen zijden A en B: ");
    var ab = Convert.ToSingle(Console.ReadLine());
    Console.Write("Hoek ingesloten tussen zijden B en C: ");
    var bc = Convert.ToSingle(Console.ReadLine());
    Console.Write("Hoek ingesloten tussen zijden A en C: ");
    var ac = Convert.ToSingle(Console.ReadLine());

    var zijden = new List<float>() { a, b, c };
    zijden.Sort();

    if (zijden[0] + zijden[1] <= zijden[2])
        throw new Exception("De som van de twee kleinere zijden mag niet groter zijn dan de grootste zijde.");
    if (ab + ac + bc < 180)
        throw new Exception("De som van de hoeken is niet gelijk aan 180°.");
    // Uitbreiding

    //Sinusregel (de verhouding tussen de lengte van een zijde en de sinus van de overstaande moet dezelfde zijn)
    var a_radialen = a * Math.PI / 180;
    var b_radialen = b * Math.PI / 180;
    var c_radialen = c * Math.PI / 180;

    var verhouding_A = bc / Math.Sin(a_radialen);
    var verhouding_B = ac / Math.Sin(b_radialen);
    var verhouding_C = ab / Math.Sin(c_radialen);

    //bij benadering, want er kunnen afrondingsfouten zijn
    if(Math.Abs(verhouding_A - verhouding_B) > 0.001)
    {
        throw new Exception("Er is een fout met hoeken A en B en de drie zijden");
    }
    if (Math.Abs(verhouding_A - verhouding_C) > 0.001)
    {
        throw new Exception("Er is een fout met hoeken A en C en de drie zijden");
    }
    if (Math.Abs(verhouding_B - verhouding_C) > 0.001)
    {
        throw new Exception("Er is een fout met hoeken B en C en de drie zijden");
    }
}catch(Exception e)
{
    Console.WriteLine(e.Message);
}