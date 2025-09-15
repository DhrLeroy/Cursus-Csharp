
using Les_12___Databanken__geavanceerd_;

var db = new Databank();

var producten = db.Producten.ToList();

//db.Producten.Add(new Product("Appel", 1.2f, "Fruit", "Lokaal"));

db.SaveChanges();