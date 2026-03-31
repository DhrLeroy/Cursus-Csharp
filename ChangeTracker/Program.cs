using ChangeTracker;
using System.Text.Json;

string json = File.ReadAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\ChangeTracker\\data.json");

List<Dier> dieren = JsonSerializer.Deserialize<List<Dier>>(json);

foreach(var dier in dieren)
{
    dier.Id = 2;
}

json = JsonSerializer.Serialize(dieren);
File.WriteAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\ChangeTracker\\data.json", json);

Console.WriteLine();

/*var conn = new Connection();

var alligator = new Dier("Kat");

conn.Add(alligator);

Console.WriteLine(conn.Entry(alligator).State);

foreach (var dier in conn.Dieren)
{
    if(dier.Soort == "Kat")
    {
        dier.Soort = "Poes";
    }
    Console.WriteLine(conn.Entry(dier).State);
    Console.WriteLine();
}


Console.WriteLine();*/