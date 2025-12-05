using Uitleg_klassen_functies_overerving;

var bintjes = new Product("AH Bintje kruimig", 2.69, 1, "zak", 1.5);
var tomaten = new Product("AH Tasty Tom trostomaten", 3.99, 1, "schaal", 0.380);
var knolselder = new Product("AH Knolselderij", 1.99, 1, "stuk", 1);
//var roerbak = new Product("AH Italiaanse roerbakgroente", 2.99, 1, "zak", 0.400);
var roerbak_courgette = new Variatie("AH Italiaanse roerbakgroente", 2.99, 1, "zak", 0.400, "Courgette");
var roerbak_rode_paprika = new Variatie("AH Italiaanse roerbakgroente", 2.99, 1, "zak", 0.400, "Rode paprika");
var roerbak_wortel = new Variatie("AH Italiaanse roerbakgroente", 2.99, 1, "zak", 0.400, "Wortel");

var promo_bintjes = new Promotie(bintjes, 1, 1);
var promo_tomaten = new Promotie(tomaten, 1, 1);
var promo_knolselder = new Promotie(knolselder, 1, 1);
var promo_roerbak_c = new Promotie(roerbak_courgette, 1, 1);
var promo_roerbak_p = new Promotie(roerbak_rode_paprika, 1, 1);
var promo_roerbak_w = new Promotie(roerbak_wortel, 1, 1);

List<Promotie> promos = new List<Promotie>()
{
    promo_bintjes, promo_tomaten, promo_knolselder, promo_roerbak_c, promo_roerbak_p, promo_roerbak_w
};

foreach(var promo in promos)
{
    promo.ToonPromo();
}