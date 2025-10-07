using Dierentuin__oplossing_;

Dier spin = new Dier("George","Kruisspin");

Dier dumbo = new Dier("Dumbo", "Olifant");
Dier olli = new Dier("Olli", "Olifant");

Dier shiro = new Dier("Shiro", "Kat");

string label_olli = olli.GeefLabel();

int jaar = 2025;

int leeftijd_george = spin.BerekenLeeftijd(jaar);
int leeftijd_dumbo = dumbo.BerekenLeeftijd(jaar);
int leeftijd_olli = olli.BerekenLeeftijd(jaar);

Verblijf olifantenparadijs = new Verblijf(100, "Grasvlakte", 4);
olifantenparadijs.Dieren.Add(dumbo);
olifantenparadijs.Dieren.Add(olli);

Medewerker john = new Medewerker();
john.Naam = "John";
john.Functie = "Verzorger";

dumbo.Favoriete_verzorger = john;