using AuteursJSON;
using System.Text.Json;

string json = File.ReadAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\AuteursJSON\\data.json");
List<Auteur> auteurs = JsonSerializer.Deserialize<List<Auteur>>(json);

var auteur = auteurs.First(a => a.Voornaam == "J.R.R." && a.Naam == "Tolkien");
auteurs.Remove(auteur);

json = JsonSerializer.Serialize(auteurs);
File.WriteAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\AuteursJSON\\data.json", json);

