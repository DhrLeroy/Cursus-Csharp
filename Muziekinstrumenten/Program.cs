using Muziekinstrumenten;

Gitaar g = new Gitaar("Normaal", 39.33f, "Gibson", false, "Nylon");
Basgitaar bg = new Basgitaar("Super", 74.99f, "Gibson", true, "Staal", "Hout", false);
Elektrische_Gitaar eg = new Elektrische_Gitaar("Mega", 100f, "Gibson", false, "Staal", 2, true);

Accesoire hoes = new Accesoire("Luxehoes", 39.99f, "Amazon", g, bg);

Muziekboek boek = new Muziekboek("H. Simpson", 120, "Beginner", "Gitaar voor beginnners", 29f, "Amazon", g, eg);

Viool v1 = new Viool("XCV1", 80f, "Yamaha", true, 2007, "Esdoorn", 4, false);
Viool v2 = new Viool("AMD2", 75f, "Yamaha", false, 1990, "Walnoot", 4, true);

var producten = new List<Product>()
{
    g,bg, v1, v2,eg,hoes,boek
};