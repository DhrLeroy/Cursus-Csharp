using Personen_JSON;
using System.Text.Json;

var persoon = new Person("Lars", 17, "lars@gmail.com");
var persoon2 = new Person("Anita", 16, "anitaaaaa@gmail.com");
var personen = new List<Person> { persoon, persoon2 };

var klas = new Klas();
klas.Naam = "5ICW";
klas.Leerlingen = personen;
klas.Titularis = "Mevrouw De Smet";

string json = JsonSerializer.Serialize(klas);

File.WriteAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\Personen_JSON\\data.json", json);

Console.WriteLine();

json = File.ReadAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\Personen_JSON\\data.json");

var deserializedPersons = JsonSerializer.Deserialize<Klas>(json);

Console.WriteLine();