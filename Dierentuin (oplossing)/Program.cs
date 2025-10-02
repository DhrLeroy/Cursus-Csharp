using Dierentuin__oplossing_;

Dier spin = new Dier("George","Kruisspin");

Dier dumbo = new Dier("Dumbo", "Olifant");
Dier olli = new Dier("Olli", "Olifant");

Verblijf olifantenparadijs = new Verblijf(100, "Grasvlakte", 4);
olifantenparadijs.Dieren.Add(dumbo);
olifantenparadijs.Dieren.Add(olli);

Medewerker john = new Medewerker();
john.Naam = "John";
john.Functie = "Verzorger";

dumbo.Favoriete_verzorger = john;