using F1_Databank;

var db = new Databank();

while (true)
{
    Console.WriteLine("GP's: ");
    foreach (var gp in db.GPs)
    {
        Console.WriteLine($"{gp.Id}: {gp.Naam} ({gp.Jaartal})");
    }
    Console.Write("Van welke GP wil je deelnemers zien? (Id, 0 voor een nieuwe GP aan te maken) ");

    var gp_id = Convert.ToInt32(Console.ReadLine());

    if (gp_id == 0)
    {
        Console.Write("Naam GP: ");
        var naam = Console.ReadLine();
        Console.Write("Jaartal: ");
        var jaartal = Convert.ToInt32(Console.ReadLine());
        var gp = new GP();
        gp.Naam = naam;
        gp.Jaartal = jaartal;
        db.GPs.Add(gp);
        db.SaveChanges();
    }
    else
    {
        var gp = db.GPs.First(gp => gp.Id == gp_id);
        Console.WriteLine("Deelnemers: ");
        foreach(var d in gp.Deelnames)
        {
            Console.WriteLine($"{d.Driver.Naam}");
        }
        Console.Write("Wil je een nieuwe deelnemer toevoegen (ja/nee)? ");
        var antwood = Console.ReadLine();
        if(antwood.Equals("ja", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Write("Deelnemer (land): ");
            var output = Console.ReadLine();
            var naam = output.Substring(0, output.IndexOf("(") - 1);
            var land = output.Substring(output.IndexOf("(") + 1, output.IndexOf(")") - output.IndexOf("(") - 1);
            var deelnemer = new Driver();
            deelnemer.Naam = naam;
            deelnemer.Land = land;
            var deelname = new Deelname();
            deelname.Driver = deelnemer;
            deelname.GP = gp;
            gp.Deelnames.Add(deelname);
            db.SaveChanges();
        }
        
    }
}