using Oefening7InleidingVoertuig;

List<Voertuig> voertuigen = new List<Voertuig>();
voertuigen.Add(new Voertuig("Tesla", "Model S", 250, true));
voertuigen.Add(new Voertuig("Volkswagen", "Golf", 200, false));
voertuigen.Add(new Voertuig("Kalkhoff", "Image 5", 25, true));

foreach (Voertuig voertuig in voertuigen)
{
    var elektrisch = "";
    if (voertuig.Elektrisch)
    {
        elektrisch = " (E)";
    }
    Console.WriteLine($"{voertuig.Merk} {voertuig.Model}{elektrisch} kan maximaal {voertuig.Maximale_snelheid_km_u} km/u rijden.");
}