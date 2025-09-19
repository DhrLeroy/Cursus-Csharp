using Herhaling_examen_2_5ICW___2045_2025___Oefening_1;

List<Kaart> kaarten = new List<Kaart>();

kaarten.Add(new PokemonMonsterkaart("Pikachu", 2023, "Kimura", "MEWen", 25, "When it is angered...", 165, "", 60, EnergyType.Elektric,
        new Pokemonaanval("Charge", 0, "Search your deck...", EnergyType.Elektric, EnergyType.Normal, EnergyType.Metal),
        new Pokemonaanval("Pika Punck", 50, "", EnergyType.Elektric, EnergyType.Elektric, EnergyType.Normal)
    ));


kaarten.Add(new Energykaart("Water", 2024, "", "MEWen", 3, "", 68));

kaarten.Add(new YugiohMonsterkaart("Blue-Eyes White Dragon", 1996, "Takahashi", "CT13-EN", 8, "This legendary dragon...", "Limited", "89631139", 8, 3000, 2500));


List<Pokemonkaart> pokemonkaarten = kaarten.OfType<Pokemonkaart>().ToList();

foreach(var k in pokemonkaarten)
{
    Console.WriteLine($"{k.Naam} ({k.NummerInSet}:{k.TotaalInSet})");
}