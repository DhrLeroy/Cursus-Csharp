using JSONRecursie_boeken;
using System.Text.Json;
using System.Text.Json.Serialization;

var boek = new Boek();
boek.Titel = "Project Hail Mary";

var auteur = new Auteur();
auteur.Naam = "Andy Weir";

boek.Auteurs.Add(auteur);
auteur.Boeken.Add(boek);

var serializeOptions = new JsonSerializerOptions()
{
    ReferenceHandler = ReferenceHandler.Preserve
};

var json = JsonSerializer.Serialize(boek, serializeOptions);
File.WriteAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\JSONRecursie_boeken\\data.json", json);