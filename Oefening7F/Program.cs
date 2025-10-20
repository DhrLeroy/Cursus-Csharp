using Oefening7F;



var bib = new Bibliotheek("Dorpsplein 1 - Gent", "Jan Jansen");

//bib.Adres = "Dorpsplein 2";

bib.StelAdresIn("Dorpsplein 2 - Gent");


bib.AantalDvds = 2;
Console.WriteLine(bib.AantalDvds);
bib.AantalDvds = 0;
Console.WriteLine(bib.AantalDvds);
bib.AantalDvds = -3;
Console.WriteLine(bib.AantalDvds);
bib.AantalDvds = 5;
Console.WriteLine(bib.AantalDvds);

Console.WriteLine(bib.GeefAdres());


Console.WriteLine(bib.Medewerker);
bib.Medewerker = "Piet Pietersen";

bib.AantalSpelletjes = 10;
Console.WriteLine(bib.AantalSpelletjes);


public class Dvd
{
    public string Titel { get; set; }
    public string Regisseur { get; set; }
    public int Speelduur { get; set; } // in minuten
    public string Genre { get; set; }
    public Dvd(string titel, string regisseur, int speelduur, string genre)
    {
        Titel = titel;
        Regisseur = regisseur;
        Speelduur = speelduur;
        Genre = genre;
    }
}