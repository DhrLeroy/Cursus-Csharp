using JSON_voorbeeld_landen;

/*Land l1 = new Land();
l1.Naam = "België";
l1.Hoofdstad = "Brussel";
l1.Oppervlakte_km2 = 30688;
l1.Populatie = 11825551;

var l2 = new Land();
l2.Naam = "Congo DR";
l2.Hoofdstad = "Kinshasa";
l2.Oppervlakte_km2 = 2345000;
l2.Populatie = 116452000;

List<Land> landen =new List<Land>();
landen.Add(l1);
landen.Add(l2);

var jsonLanden = new JsonLanden();
jsonLanden.SlaLandenOp(landen);*/

var jsonLanden = new JsonLanden();
var landen = jsonLanden.GeefLanden();

foreach(var land in landen)
{
    land.Oppervlakte_km2 = 100;
    Console.WriteLine(land.Naam);
}