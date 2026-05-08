Console.Write("Geef uw verjaardag in.\nDag: ");
var dag = Convert.ToInt32(Console.ReadLine());
Console.Write("Maand: ");
var maand = Convert.ToInt32(Console.ReadLine());

var volgendeVerjaardag = new DateTime(DateTime.Today.Year, maand, dag);

if (volgendeVerjaardag < DateTime.Today)
    volgendeVerjaardag = volgendeVerjaardag.AddYears(1);

var verschil = volgendeVerjaardag - DateTime.Today;

Console.WriteLine($"Proficiat, je verjaart binnen {verschil.Days} dagen!");