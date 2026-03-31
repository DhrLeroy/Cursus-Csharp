using ProductenKlantenJson;
using System.Text.Json;

var k1 = new Klant();
k1.Naam = "ABC";
k1.Krediet = 100;

var k2  = new Klant();
k2.Naam = "DEF";
k2.Krediet = 200;

var p1 = new Product();
p1.Naam = "Appel";
p1.Prijs = 2;

List<Klant> klanten = new List<Klant>() { k1, k2 };
List<Product> producten = new List<Product> { p1 };

var db = new Databestand();
db.Klanten = klanten;
db.Producten = producten;
db.Adres = "Dorpstraat 1";

File.WriteAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\ProductenKlantenJson\\data.json", JsonSerializer.Serialize(db));