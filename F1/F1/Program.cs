// Red Bull Racing
using F1;

List<Team> teams = new List<Team>();

var verstappen = new Driver("Max Verstappen", Country.Nederland);
var tsunoda = new Driver("Yuki Tsunoda", Country.Japan);
var rb1 = new Car("RBR-001", 1050, 796);
var rb2 = new Car("RBR-002", 1050, 796);
var redBull = new Team("Red Bull Racing", new[] { verstappen, tsunoda }, rb1, rb2);
verstappen.Team = redBull;
tsunoda.Team = redBull;
teams.Add(redBull);

// Mercedes
var russell = new Driver("George Russell", Country.VerenigdKoninkrijk);
var hamilton = new Driver("Lewis Hamilton", Country.VerenigdKoninkrijk);
var merc1 = new Car("MERC-001", 1020, 798);
var merc2 = new Car("MERC-002", 1020, 798);
var mercedes = new Team("Mercedes", new[] { russell, hamilton }, merc1, merc2);
russell.Team = mercedes;
hamilton.Team = mercedes;
teams.Add(mercedes);

// Ferrari
var leclerc = new Driver("Charles Leclerc", Country.Monaco);
var sainz = new Driver("Carlos Sainz Jr.", Country.Spanje);
var fer1 = new Car("FER-001", 1030, 799);
var fer2 = new Car("FER-002", 1030, 799);
var ferrari = new Team("Ferrari", new[] { leclerc, sainz }, fer1, fer2);
leclerc.Team = ferrari;
sainz.Team = ferrari;
teams.Add(ferrari);

// McLaren
var norris = new Driver("Lando Norris", Country.VerenigdKoninkrijk);
var piastri = new Driver("Oscar Piastri", Country.Australië);
var mcl1 = new Car("MCL-001", 1010, 797);
var mcl2 = new Car("MCL-002", 1010, 797);
var mclaren = new Team("McLaren", new[] { norris, piastri }, mcl1, mcl2);
norris.Team = mclaren;
piastri.Team = mclaren;
teams.Add(mclaren);

// Aston Martin
var alonso = new Driver("Fernando Alonso", Country.Spanje);
var stroll = new Driver("Lance Stroll", Country.Canada);
var am1 = new Car("AMR-001", 1005, 798);
var am2 = new Car("AMR-002", 1005, 798);
var aston = new Team("Aston Martin", new[] { alonso, stroll }, am1, am2);
alonso.Team = aston;
stroll.Team = aston;
teams.Add(aston);

// Alpine
var gasly = new Driver("Pierre Gasly", Country.Frankrijk);
var ocon = new Driver("Esteban Ocon", Country.Frankrijk);
var alp1 = new Car("ALP-001", 990, 799);
var alp2 = new Car("ALP-002", 990, 799);
var alpine = new Team("Alpine", new[] { gasly, ocon }, alp1, alp2);
gasly.Team = alpine;
ocon.Team = alpine;
teams.Add(alpine);

// Williams
var albon = new Driver("Alexander Albon", Country.Thailand);
var sargeant = new Driver("Logan Sargeant", Country.VS);
var wil1 = new Car("WIL-001", 980, 800);
var wil2 = new Car("WIL-002", 980, 800);
var williams = new Team("Williams", new[] { albon, sargeant }, wil1, wil2);
albon.Team = williams;
sargeant.Team = williams;
teams.Add(williams);

// Kick Sauber (ex-Alfa Romeo)
var bottas = new Driver("Valtteri Bottas", Country.Finland); // voeg 'Finland' toe aan enum
var hulkenberg = new Driver("Nico Hülkenberg", Country.Duitsland);
var ks1 = new Car("KS-001", 970, 801);
var ks2 = new Car("KS-002", 970, 801);
var sauber = new Team("Kick Sauber", new[] { bottas, hulkenberg }, ks1, ks2);
bottas.Team = sauber;
hulkenberg.Team = sauber;
teams.Add(sauber);

// Haas
var magnussen = new Driver("Kevin Magnussen", Country.Denemarken); // voeg 'Denemarken' toe
var bearman = new Driver("Oliver Bearman", Country.VerenigdKoninkrijk);
var haas1 = new Car("HAA-001", 960, 802);
var haas2 = new Car("HAA-002", 960, 802);
var haas = new Team("Haas", new[] { magnussen, bearman }, haas1, haas2);
magnussen.Team = haas;
bearman.Team = haas;
teams.Add(haas);

// RB (Visa Cash App RB, ex-AlphaTauri)
var ricciardo = new Driver("Daniel Ricciardo", Country.Australië);
var lawson = new Driver("Liam Lawson", Country.NieuwZeeland); // voeg 'NieuwZeeland' toe
var rbv1 = new Car("RB-001", 975, 799);
var rbv2 = new Car("RB-002", 975, 799);
var rbTeam = new Team("Visa Cash App RB", new[] { ricciardo, lawson }, rbv1, rbv2);
ricciardo.Team = rbTeam;
lawson.Team = rbTeam;
teams.Add(rbTeam);


List<Race> races = new List<Race>()
{
    new Race("GP van Australië", new DateOnly(2025,3,16)),
    new Race("GP van China", new DateOnly(2025,3,23)),
    new Race("GP van Japan", new DateOnly(2025,4,6)),
    new Race("GP van Bahrein", new DateOnly(2025, 4, 13)),
    new Race("GP van Saoedi-Arabië", new DateOnly(2025,4,20)),
    new Race("GP van Miami", new DateOnly(2025,4,20)),
    new Race("GP van Monza", new DateOnly(2025, 5, 18))
};

var rndm = new Random();
foreach (var race in races)
{
    int laps = rndm.Next(16, 20);
    foreach (var driver in teams.SelectMany(t => t.Drivers).ToList())
    {
        List<TimeSpan> lapTimes = new List<TimeSpan>();
        for (int lap = 0; lap < laps; lap++)
        {
            lapTimes.Add(new TimeSpan(0, rndm.Next(1, 3), rndm.Next(0, 60)));
        }
        race.VoegUitslagToe(driver, new TimeSpan(0, 0, rndm.Next(0, 30) == 0 ? rndm.Next(0, 3) * 5 : 0), lapTimes.ToArray());
    }
}



//Select

//lijst met namen van teams
List<string> teamnamen = teams.Select(t => t.Naam).ToList();

//
List<string> teamnamen_met_spatie = teamnamen.Where(tn => tn.Contains(" ")).ToList();
/*List<string> teamnamen_met_spatie = teams
    .Select(t => t.Naam)
    .Where(t => t.Contains(" ")).ToList();*/

//lijst met namen van races
List<string> race_namen = races.Select(race => race.Naam).ToList();


//lijst met namen van races en aantal deelnemers




//SelectMany
//lijst met alle drivers
List<Driver> drivers = new List<Driver>();
foreach(var team in teams)
{
    foreach(var driver in team.Drivers)
    {
        drivers.Add(driver);
    }
}
drivers = teams.SelectMany(t => t.Drivers).ToList();

//lijst met alle autos
var autos = teams.Select(t => t.Autos).ToList();

//lijst van teamnamen met aantal auto's
var teamnamen_met_autos = teams.Select(t => $"{t.Naam}: {t.Autos.Count}").ToList();

var teamnamen_met_autos_2 = teams.Select(t => new TeamMetAantalAutos(t.Naam, t.Autos.Count, t.Drivers.Count, t.Drivers.SelectMany(d => d.Uitslagen).Count())).ToList();

foreach(var team in teamnamen_met_autos_2)
{
    Console.WriteLine($"{team.Teamnaam}: {team.Aantal_autos} auto's.");
}

var teamnamen_met_autos_3 = teams.Select(t => new
                                            {
                                                Teamnaam = t.Naam,
                                                Aantal_autos = t.Autos.Count,
                                                Aantal_drivers = t.Drivers.Count,
                                                Aantal_deelnames = t.Drivers.SelectMany(d => d.Uitslagen).Count()

                                            }).ToList();


foreach (var team in teamnamen_met_autos_3)
{
    Console.WriteLine($"{team.Teamnaam}: {team.Aantal_autos} auto's.");
}
//lijst van alle deelnames
List<Deelname> deelnames = teams.SelectMany(t => t.Drivers).SelectMany(d => d.Uitslagen).ToList();

//lijst van alle deelnames (Race: driver)
List<string> deelnames_race_driver = deelnames.Select(d => $"{d.Wedstrijd.Naam}: {d.Driver.Naam}").ToList();




//Sum
//gewicht van alle autos tesamen


//totaal van alle deelnames (alle racetijd)



//Where
//GP van Monze



//Sum, Average, Min, Max
//deelnames van Monza: Deelnemer naam (Deelnemer Team): Minimaal: ... , Gemiddelde: ... , Maximaal: ... , Totaaltijd : ...


//Klassement van Monza




//Where
//lijst van alle autos die minder wegen dan 800 kg
var cars_under800 = teams.SelectMany(t => t.Autos).Where(a => a.Gewicht < 800).ToList();

//lijst van teamsnamen die een auto hebben die minder dan 800 kg weegt
List<string> teams_with_cars_under_800 = teams.Where(t => t.Autos.Select(a => a.Gewicht).Where(g => g < 800).ToList().Count > 0)
    .Select(t => t.Naam).ToList();


//lijst van alle drivers die uit VK komen



Console.WriteLine();
Console.ReadLine();
