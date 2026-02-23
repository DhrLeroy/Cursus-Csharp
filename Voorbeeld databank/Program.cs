using Voorbeeld_databank;

Console.Write("Merk: ");
var merk = Console.ReadLine();
Console.Write("Model: ");
var model = Console.ReadLine();
Console.Write("Maximale snelheid (km/u): ");
var maximale_snelheid_km_u = Convert.ToDouble(Console.ReadLine());
Console.Write("Elektrisch (ja/nee): ");
var elektrisch = false;
if(Console.ReadLine().ToLower() == "ja")
{
    elektrisch = true;
}
var voertuig = new Voertuig(merk, model, maximale_snelheid_km_u, elektrisch);

var db = new Connectie();
db.Voertuigen.Add(voertuig);
db.SaveChanges();

foreach (Voertuig v in db.Voertuigen)
{
    var e = "";
    if (v.Elektrisch)
    {
        e = " (E)";
    }
    Console.WriteLine($"{v.Merk} {v.Model}{e} kan maximaal {v.Maximale_snelheid_km_u} km/u rijden.");
}