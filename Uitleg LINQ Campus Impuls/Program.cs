using Uitleg_LINQ_Campus_Impuls;

List<Pokémon> pokemons = new List<Pokémon>()
{

    new Pokémon("Charmander", 39, "fire", 0.6,8.5),
    new Pokémon("Snorlax", 70, "normal", 2, 800),
    new Pokémon("Mewtwo", 1, "psychic", 2, 60),
    new Pokémon("Arcanine", 90, "fire", 1, 85),
    new Pokémon("Charmeleon", 70, "fire", 1, 40),
    new Pokémon("Squirtle", 40, "water", 0.5, 10),
    new Pokémon("Magikarp", 40, "water", 0.9, 10),
    new Pokémon("Pidgey", 40, "flying", 0.3, 1.8),
    new Pokémon("Bulbasaur", 45, "grass", 0.7, 6.9),
    new Pokémon("Rattata", 30, "normal", 0.3, 3.5),
    new Pokémon("Pikachu", 35, "electric", 0.4, 6),
};








//Select: haalt beperkte data uit een lijst
// TRANSFORMATIE

//namen van alle Pokémons
List<string> namen = pokemons.Select(p => p.Naam).ToList();

//HP's van alle Pokémons
List<int> hps = pokemons.Select(x => x.Base_HP).ToList();

//lengtes van de namen van alle Pokémons
List<int> lengtes_names = pokemons.Select(p => p.Naam.Length).ToList();



//Where: filter object uit een lijst

//pokémons met een Base HP groter dan 40
List<Pokémon> pokemons_BaseHP_groterdan40 = pokemons.Where(p => p.Base_HP > 40).ToList();

//alle waterpokémons
List<Pokémon> waterpokémons = pokemons.Where(p => p.Type.ToLower() == "water").ToList();

//pokémons met overgewicht
List<Pokémon> pokemons_overgewicht = pokemons.Where(p => p.Gewicht / (p.Hoogte * p.Hoogte) > 25).ToList();



//ANY : bepaalt of minstens één object aan een bepaalde voorwaarde voldoet

bool bestaan_flying_pokemons = pokemons.Any(p => p.Type == "flying");
bestaan_flying_pokemons = pokemons.Where(p => p.Type == "flying").ToList().Count > 0;

bool zijn_er_pokémons_baseHP_groterdan_50 = pokemons.Any(p => p.Base_HP > 50);

bool zijn_er_pokemons_minstens_1m = pokemons.Any(p => p.Hoogte >= 1);

/*bool minstens_1m = false;
foreach(var p in pokemons)
{
    if (p.Hoogte >= 1)
    {
        minstens_1m = true;
        break;
    }
}*/


//ALL : bepaalt of alle objecten aan een bepaalde voorwaarde voldoen

bool alle_pokemons_een_type = pokemons.All(p => p.Type != "");

bool alle_pokémons_minstens_20_BaseHP = pokemons.All(p => p.Base_HP >= 20);




//SUM : bepaal de som van een reeks getallen

var totaal_alle_BaseHPs = pokemons.Select(p => p.Base_HP).Sum();
totaal_alle_BaseHPs = pokemons.Sum(p => p.Base_HP);

var totaal_alle_gewichten = pokemons.Sum(p => p.Gewicht);

/*double totaal = 0;
foreach(var p in pokemons)
{
    totaal += p.Gewicht;
}*/

//AVERAGE : bepaal het gemiddel van een reeks getallen

var gemiddelde_hoogte = pokemons.Average(p => p.Hoogte);

/*
double totaal = 0;
foreach(var p in pokemons)
{
    totaal += p.Hoogte;
}
double gemiddelde = totaal / pokemons.Count;*/

var gemiddelde_HP = pokemons.Average(p => p.Base_HP);

//MIN : kleinste waarde van een reeks

var laagste_hoogte = pokemons.Min(p => p.Hoogte);
laagste_hoogte = pokemons.Select(p => p.Hoogte).Min();

var alfabetisch_eerste_naam = pokemons.Min(p => p.Naam);


//MAX : hoogste waarde van een reeks


var hoogste_hoogte = pokemons.Max(p => p.Hoogte);
hoogste_hoogte = pokemons.Select(p => p.Hoogte).Max();

var alfabetisch_laatste_naam = pokemons.Max(p => p.Naam);

var max = pokemons.Max(po => po.Base_HP);
List<Pokémon> pokémons_hoogste_HP = pokemons.Where(p => p.Base_HP == max).ToList();



//COUNT : telt het aantal elementen in een lijst

var aantal_pokémons = pokemons.Count();

var aantal_waterpokémons = pokemons.Where(p => p.Type == "water").Count();
aantal_waterpokémons = pokemons.Count(p => p.Type == "water");


//DISTINCT : zonder dubbele waarden

var alle_types_geen_dubbels = pokemons.Select(p => p.Type).Distinct().ToList();


List<Pokémon> waterpokemons = pokemons.Where(p => p.Type.ToLower() == "water").ToList();
List<Pokémon> pokémons_baseHP_vanaf40 = pokemons.Where(p => p.Base_HP >= 40).ToList();

// CONCAT
var waterpokemon_en_pokemons_baseHP_vanaf40 = waterpokemons.Concat(pokémons_baseHP_vanaf40);

// UNION
var waterpokemon_of_pokemons_baseHP_vanaf40 = waterpokemons.Union(pokémons_baseHP_vanaf40);

// INTERSECT
var waterpokemons_met_baseHP_vanaf40 = waterpokemons.Intersect(pokémons_baseHP_vanaf40);

// EXCEPT
var waterpokemons_met_baseHP_lagerdan40 = waterpokemons.Except(pokémons_baseHP_vanaf40);


// ORDER BY

var pokemons_alfabetisch_op_naam = pokemons.OrderBy(p => p.Naam).ToList();

var pokemons_alfabetisch_op_type = pokemons.OrderBy(p => p.Type)
    .ThenBy(p => p.Base_HP)
    .ThenBy(p => p.Gewicht)
    .OrderBy(p => p.Naam)
    .ToList();

var pokemons_volgens_type_Z_naar_A = pokemons.OrderByDescending(p => p.Type).ToList();

var pokemons_volgens_wel_niet_vuur = pokemons.OrderBy(p => p.Type == "fire")
    .ThenByDescending(p => p.Naam)
    .ToList();


var getallen = new List<int>() { 1, 3, 4, 2, 5 };
var gesorteerd = getallen.Order();
Console.WriteLine(string.Join(",", gesorteerd));
getallen.Sort();
Console.WriteLine(string.Join(",", getallen));






//GROUP BY


var pokemons_volgens_type = pokemons.GroupBy(p => p.Type).ToList();


Console.WriteLine(pokemons.Count);
Console.WriteLine(pokemons.Capacity);
foreach (var pok in pokemons)
{
    Console.WriteLine(pok.Naam);
}

foreach (var groep in pokemons_volgens_type)
{
    Console.WriteLine($"{groep.Key}: {string.Join(", ", groep.Select(p => p.Naam))}");
}


// TAKE SKIP

var pokemons_2_4 = pokemons.Select(p => p.Naam).Order().Skip(1).Take(3);

Console.WriteLine();
Console.WriteLine();