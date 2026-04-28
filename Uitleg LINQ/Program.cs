using System.ComponentModel.DataAnnotations;
using Uitleg_LINQ;

List<Pokémon> pokemons = new List<Pokémon>(){
     new Pokémon("Bulbasaur", 45, "grass", 0.7,6.9),
    new Pokémon("Charmander", 39, "fire", 0.6,8.5),
    new Pokémon("Charmeleon", 65, "fire", 1.6,15),
    new Pokémon("Squirtle", 44, "water", 0.5, 9),
    new Pokémon("Magikarp", 20, "water", 0.9, 10)
};

var db = new Connectie();


//SELECT = transformatie van het ene type naar het andere

//Klasse Pokémon => string
var namen = pokemons.Select(p => p.Naam).ToList();


//Klasse Pokémon => float
var hoogtes = pokemons.Select(p => p.Hoogte).ToList();



//WHERE = filteren van items

var pokemons_groter_dan_50cm = pokemons.Where(p => p.Hoogte > 0.5).ToList();

var waterpokemons = db.Pokémons.Where(p => p.Type.ToLower() == "water").ToList();


//SUM = tel alle getallen bij elkaar op

//geef het totaalgewicht van alle Pokémons
var totaal = db.Pokémons.Sum(e => e.Gewicht);
totaal = db.Pokémons.Select(p => p.Gewicht).Sum();

//geef het totaalhoogte van alle Pokémons
var totaalVolume = db.Pokémons.Sum(p => p.Hoogte);

//geef de totale lengte van de namen van alle Pokémons
var totaalNamen = db.Pokémons.Sum(p => p.Naam.Length);

//geef de totale Base HP van alle Pokémons
var totaalHP = db.Pokémons.Sum(e => e.Base_HP);


//AVERAGE = bereken gemiddelde van een reeks getallen

//bereken gemiddelde HP
var gemiddeldeHP = db.Pokémons.Average(e => e.Base_HP);
gemiddeldeHP = db.Pokémons.Select(e => e.Base_HP).Average();

//bereken gemiddeld gewicht
var gemiddeldGewicht = db.Pokémons.Average(e => e.Gewicht);

//bereken gemiddelde lengte
var gemiddeldeLengte = db.Pokémons.Average(e => e.Hoogte);


//MIN = bereken de laagste waarde
var laagsteNaam = db.Pokémons.Min(e => e.Naam);

//bereken de laagste HP
var laagsteHP = db.Pokémons.Min(e => e.Base_HP);

//bereken het laagste gewicht
var minsteGewicht = db.Pokémons.Min(e => e.Gewicht);

//MAX = bereken de hoogte waarde
var hoogsteNaam = db.Pokémons.Max(e => e.Naam);

//bereken de hoogte HP
var hoogsteHP = db.Pokémons.Max(e => e.Base_HP);

//bereken het laagste gewicht
var hoogteLengte = db.Pokémons.Max(e => e.Hoogte);

//haal Pokémons op met het hoogste HP
var pokémonsMetHoogsteHP = db.Pokémons.Where(e => e.Base_HP == db.Pokémons.Max(d => d.Base_HP)).ToList();

//bereken het hoogste gewicht
var hoogsteGewicht = db.Pokémons.Max(e => e.Gewicht);


//COUNT = telt het aantal element

//bereken aantal Pokémons
var aantalPokémons = db.Pokémons.Count();

//bereken het aantal Water-Pokémons
var aantalWaterPokémons = db.Pokémons.Where(e => e.Type == "water").Count();

//hoeveel unieke beginletters zijn er in de namen van Pokémon
var aantalUniekeBeginletters = db.Pokémons.Select(p => p.Naam.Substring(0,1).ToUpper()).Distinct().Count();


//ANY = geeft weer of minstens één element aan een voorwaarde voldoet

// bestaan er water Pokémons?
var bestaanErWaterPokémons = db.Pokémons.Any(e => e.Type == "water");
bestaanErWaterPokémons = db.Pokémons.Where(p => p.Type == "water").Count() > 0;

// bestaan er Pokémons met een HP boven 40?
var bestaanErPokémonsMetHPBoven40 = db.Pokémons.Any(e => e.Base_HP > 40);

// bestaan er Pokémons kleiner dan 50 cm?
var zijnErPokémonsKleinerDan50cm = db.Pokémons.Any(e => e.Hoogte < 50);

//ALL = geeft weer of elke/alle elementen aan een voorwaarde voldoen

//is elke Pokémon zwaarder dan 8 kg?
var alleZwaarderDan8kg = db.Pokémons.All(e => e.Gewicht > 8);
alleZwaarderDan8kg = db.Pokémons.Where(p => p.Gewicht > 8).Count() == db.Pokémons.Count();

//zijn alle Pokémons Water-Pokémons?
var allemaalWaterPokémons = db.Pokémons.All(e => e.Type == "water");

//zijn er geen Water-Pokémons?
var geenWaterPokémons = db.Pokémons.All(e => e.Type != "water");

//zijn niet alle Pokémons Water-Pokémons?
var nietAllemaalWaterPokémons = db.Pokémons.Any(e => e.Type != "water");
nietAllemaalWaterPokémons = db.Pokémons.All(e => e.Type == "water") == false;
//niet goed!!
nietAllemaalWaterPokémons = db.Pokémons.Where(e => e.Type == "water").Count() < db.Pokémons.Count();

//DISTINCT = lijst van unieke waarden

var Base_HPs = db.Pokémons.Select(p => p.Base_HP).ToList();

//lijst van unieke BASE HP's
List<int> unieke_Base_HPs = db.Pokémons.Select(p => p.Base_HP).Distinct().ToList();

//lijst van de verschillende gewichten
var verschillende_gewichten = db.Pokémons.Select(e => e.Gewicht).Distinct().ToList();


//ORDER BY = sorteer elementen op een bepaalde eigenschap van laag naar hoog

var gesorteerde_pokemons_op_naam = db.Pokémons.OrderBy(e => e.Naam).ToList();

var gesorteerde_pokemons_op_gewicht = db.Pokémons.OrderBy(e => e.Gewicht).ToList();


//ORDER BY DESC = sorteer elementen op een bepaalde eigenschap van hoog naar laag

var gesorteerde_pokemons_op_naam_hoog_naar_laag = db.Pokémons.OrderByDescending(e => e.Naam).ToList();

var gesorteerde_pokemons_op_gewicht_hoog_naar_laag = db.Pokémons.OrderByDescending(e => e.Gewicht).ToList();

//THEN BY = sorteert elementen vervolgens op een bijkomende eigenschap (van laag naar hoog, hoog naar laag met Descending)

var sorteer_op_hpLH_gewichtHL = db.Pokémons
    .OrderBy(e => e.Base_HP)
    .ThenByDescending(e => e.Gewicht)
    .ThenBy(e => e.Hoogte)
    .ThenByDescending(e => e.Naam)
    .ToList();


sorteer_op_hpLH_gewichtHL = db.Pokémons
    .OrderBy(e => e.Base_HP)
    .OrderBy(e => e.Gewicht)
    .OrderBy(e => e.Hoogte)
    .OrderBy(e => e.Naam)
    .ToList();
Console.WriteLine();


List<string> alfabet = new List<string>();
alfabet.Capacity = 3;
alfabet.Add("A");
alfabet.Add("B");
alfabet.Add("C");
alfabet.Add("D");
alfabet.Add("E");
alfabet.Add("F");
alfabet.Add("G");

List<string> klinkers = new List<string>() { "A", "E", "O", "U", "I" };

List<string> lettersVanMijnNaam = new List<string> { "B", "O", "B" };

// a = A E O U I B O B
var a = klinkers.Concat(lettersVanMijnNaam);
// b = A E O U I B
var b = klinkers.Union(lettersVanMijnNaam);
// c = O
var c = klinkers.Intersect(lettersVanMijnNaam);
// d = A E U I
var d = klinkers.Except(lettersVanMijnNaam);
// e = B
var e = lettersVanMijnNaam.Except(klinkers);


// GROUP BY = Groepeert elementen volgens een bepaalde eigenschap

var gegroepeerd_op_eerste_letter = pokemons.GroupBy(e => e.Naam.Substring(0,1)).ToList();

foreach(var groep in gegroepeerd_op_eerste_letter)
{
    Console.Write($"{groep.Key}: ");
    foreach(var element in groep)
    {
        Console.Write(element.Naam);
    }
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine();