using Oplossing7G;

List<Wedstrijd> wedstrijden = new List<Wedstrijd>();

var speler1 = new Speler("Courtois", "Thibau", "DM");
var speler2 = new Speler("De Bruyne", "Kevin", "AM");
var speler3 = new Speler("Lukaku", "Romelu", "ST");
var speler4 = new Speler("Mertens", "Dries", "ST");
var speler5 = new Speler("Hazard", "Eden", "AM");
List<Speler> spelers = new List<Speler>()
{
    speler1,
    speler2,
    speler3
};


Wedstrijd wedstrijd1 = new Wedstrijd("Slagerij Gino", spelers);
wedstrijd1.VerhoogScore(true);
wedstrijd1.VerhoogScore(false);
wedstrijd1.VerhoogScore(true);

wedtrijd1