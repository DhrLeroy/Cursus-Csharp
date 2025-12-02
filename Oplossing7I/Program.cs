using Oplossing7I;

var spag = new Hoofdgerecht("Spaghetti Bolognaise", 17.5f, 1, "Pasta", "Capellini", "Ragout", "Emmentaal", "Tabasco");
var pastamix = new Hoofdgerecht("Mix van 4 pasta's", 23f, 2, "Pasta", "Capellini", "Ragout", "Emmentaal", "Tabasco", "Lasagnebladen", "Bechamelsaus", "Cheddar", "Ravioli", "Spanizie", "Room", "Tomatensaus", "Ansjovis", "Kappers", "Basilicum");
var coupeFruit = new Nagerecht("Coupe fruit", 24, 1, true);
var koffie_ammaretto = new Nagerecht("Koffie deluxe", 18, 1, false);
var tiramisu = new Nagerecht("Tiramisu", 16, 1, true);

var bestelling = new Bestelling(spag, spag, coupeFruit, koffie_ammaretto);
bestelling.BetaalSaldo(80);
Console.Write("Hoeveel fooi wil je geven? ");
int fooiPercentage = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"De fooi is {bestelling.BerekenFooi(fooiPercentage)} euro.");

/*
List<Gerecht> menulijst = new List<Gerecht>()
{
    spag,
    pastamix,
    coupeFruit,
    koffie_ammaretto,
    tiramisu
};

foreach(var gerecht  in menulijst)
{
    gerecht.ToonGerecht();
    Console.Write("Hoeveel keer wil je dit bestellen? ");
    int aantal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Hoeveel voor kinderen? ");
    int kind = Convert.ToInt32(Console.ReadLine());
    if (gerecht is Nagerecht nagerecht)
    {
        Console.WriteLine($"Dit kost u {nagerecht.BerekenPrijsDessert(kind)} euro.");
        if(aantal > kind)
        {
            Console.WriteLine($"Dit kost u {gerecht.BerekenPrijs(aantal-kind)} euro.");
        }
    }
    else {
        Console.WriteLine($"Dit kost u {gerecht.BerekenPrijs(aantal)} euro.");
    }

    

}

*/