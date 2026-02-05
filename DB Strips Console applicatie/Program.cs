using DB_Strips_Databank;
using System.Globalization;

var db = new Connectie();

while (true)
{
    Console.Write("Wat wil je beheren? (S = Strips, A = Albums, T = Tekenaars) ");
    var keuze = Console.ReadLine().ToUpper();
    if (keuze == "S")
    {
        Console.WriteLine("Strips:");
        foreach (var strip in db.Strips)
        {
            Console.WriteLine($"{strip.Album.Titel} ({strip.Prijs})");
        }
    }else if(keuze == "A")
    {
        Console.WriteLine("Albums: ");
        foreach (var album in db.Albums)
        {
            Console.WriteLine($"{album.Serie}: {album.Titel}");
        }
        Console.Write("Wil je een album toevoegen? ");
        if (Console.ReadLine().ToLower() == "ja")
        {
            Console.Write("Serie: ");
            var serie = Console.ReadLine();
            Console.Write("Titel: ");
            var t = Console.ReadLine();
            var album = new Album();
            album.Titel = t;
            album.Serie = serie;
            Console.WriteLine("Kies een tekenaar (Id): ");
            foreach (var tekenaar in db.Tekenaars)
            {
                Console.WriteLine($"{tekenaar.Id}: {tekenaar.Voornaam} {tekenaar.Naam}");
            }
            var t_id = Convert.ToInt32(Console.ReadLine());
            var t = db.Tekenaars.First(t => t.Id == t_id);
            album.Tekenaar = t;

            db.SaveChanges();
        }
    }
    else if(keuze == "T")
    {
        Console.WriteLine("Tekenaars: ");
        foreach(var tekenaar in db.Tekenaars)
        {
            Console.WriteLine($"{tekenaar.Voornaam} {tekenaar.Naam}");
        }
        Console.Write("Wil je een tekenaar toevoegen? ");
        if (Console.ReadLine().ToLower() == "ja")
        {
            Console.Write("Voornaam: ");
            var vn = Console.ReadLine();
            Console.Write("Naam: ");
            var n = Console.ReadLine();
            Console.Write("Geboortedatum (dd/mm/jjjj): ");
            var d = DateTime.Parse(Console.ReadLine());
            var tekenaar = new Tekenaar();
            tekenaar.Voornaam = vn;
            tekenaar.Naam = n;
            tekenaar.Geboortedatum = d;
            db.Tekenaars.Add(tekenaar);
            db.SaveChanges();
        }
    }
    
}


