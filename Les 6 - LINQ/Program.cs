/*var namen = new List<string>()
{
    "Bert",
    "Javis",
    "Ellie",
    "Mo",
    "Enes"
};



var eerste_letters = new List<string>();
foreach (var naam in namen)
{
    eerste_letters.Add(naam.Substring(0, 1));
}
eerste_letters = namen.Select(naam => naam.Substring(0, 1)).ToList();

List<int> lengtes_namen = namen.Select(n => n.Length).ToList();


Console.WriteLine($"Eerste letters: {string.Join(", ", eerste_letters)}");

var namen_in_kleine_letters = new List<string>();
foreach(var naam in namen)
{
    namen_in_kleine_letters.Add(naam.ToLower());
}
namen_in_kleine_letters = namen.Select(n =>  n.ToLower()).ToList();
Console.WriteLine($"Namen kleine letters: {string.Join(", ", namen_in_kleine_letters)}");

var namen_lengtes = namen.Select(naam => $"{naam} ({naam.Length})");
Console.WriteLine($"Namen lengtes: {string.Join(", ", namen_lengtes)}");

var namen_start_b = namen
    .Where(naam => naam.StartsWith("B", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine($"Namen beginnent met B: {string.Join(", ", namen_start_b)}");

var namen_langer_dan_4 = namen
    .Where(naam => naam.Length > 4);
Console.WriteLine($"Namen langer dan 4: {string.Join(", ", namen_langer_dan_4)}");

var namen_met_o = namen.Where(naam => naam.Contains("o", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine($"Namen met o: {string.Join(", ", namen_met_o)}");

var namen_eindigt_op_s = namen
    .Where(naam => naam.EndsWith("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine($"Namen eindigend op een s: {string.Join(", ", namen_eindigt_op_s)}");

var namen_met_l_op_2de_plaats = namen.Where(naam => naam.IndexOf("l") == 1);
Console.WriteLine($"Namen met l op de 2de plaats: {string.Join(", ", namen_met_l_op_2de_plaats)}");

List<int> getallen = new List<int>() { 23, 41, 88, -22, 61, 0 };

var deling_door_2 = getallen.Select(getal => getal / 2f);
Console.WriteLine($"Deling door 2: {string.Join("  |  ", deling_door_2)}");
var machten_2 = getallen.Select(g => g*g);
Console.WriteLine($"Deling door 2: {string.Join("  |  ", machten_2)}");
var tientallen = getallen.Select(g => g - g % 10);
Console.WriteLine($"Deling door 2: {string.Join("  |  ", tientallen)}");
var vierkantswortels = getallen.Select(g => Math.Sqrt(g));
Console.WriteLine($"Deling door 2: {string.Join("  |  ", vierkantswortels)}");
var stralen = getallen;
var omtrekken_cirkels = stralen.Select(s => Math.Abs(s * 2 * Math.PI));
Console.WriteLine($"Omtrekken cirkels: {string.Join("  |  ", omtrekken_cirkels)}");*/





using Les_6___LINQ;

List<int> getallen = new List<int> { -1, -2, 0, -3, 1, 2, 3, 4, 5, 6, 19, 12, -22, 36, -87 };

List<double> kwadraten = new List<double>();

foreach(var getal in getallen)
{
    kwadraten.Add(Math.Pow(getal, 2));
}

kwadraten = getallen.Select(getal => Math.Pow(getal, 2)).ToList();
var gemiddelde = getallen.Where(g => g != 0).Average();
gemiddelde = 0;
var som = 0;
var getallen_nietnul = 0;
foreach(var g in getallen)
{
    if(g != 0)
    {
        som += g;
        getallen_nietnul++;
    }
}
gemiddelde = Convert.ToSingle(som) / getallen_nietnul;




var stikt_positieve_getallen = getallen.Where(g => g > 0).ToList();

var tienvouden = getallen.Select(g => g * 10).ToList();

var vierkantswortel = getallen.Select(g => Math.Sqrt(g)).ToList();

var derdemachtswortels = getallen.Select(g => Math.Pow(g, 1 / 3f));

var positieve_eenheden = getallen.Where(g => g >= 0).Select(g => g % 10).ToList();




List<string> namen = new List<string>()
{
    "Lexi",
    "Louis + ",
    "Jules Henri",
    "Chacha + Chocho",
    "Shiro",
    "George",
    "Martha"
};

var eerste_letters = namen.Select(naam => naam.Substring(0, 1)).Distinct().ToList();

eerste_letters.Clear();

foreach(var naam in namen)
{
    var letter = naam.Substring(0, 1);
    if (!eerste_letters.Contains(letter))
    {
        eerste_letters.Add(letter);
    }
}


var namen_langer_dan_4 = namen.Where(n => n.Length > 4).ToList();

var namen_met_e = namen.Where(n => n.Contains("e", StringComparison.CurrentCultureIgnoreCase)).ToList();

var gestorven_dieren = namen.Where(n => n.Trim().EndsWith("+")).ToList();

var namen_in_hoofdletters = namen.Select(n => n.ToUpper()).ToList();

//lambda

var tweelingen = namen.Where(n => n.Trim().IndexOf("+") < n.Trim().Length - 2).ToList();













List<Film> films = new List<Film>()
{
    new Film(1,"IT",8,new TimeSpan(1,30,0),"Horror"),
    new Film(2,"Avengers: End Game", 9, new TimeSpan(1,20,0),"Actie"),
    new Film(3,"IT (1983)",7,new TimeSpan(1,10,0),"Horror")
};

List<string> titels_films = films.Select(film => film.Titel).ToList();

foreach(var titel in titels_films)
{
    Console.WriteLine(titel);
}

titels_films.Clear();

foreach(var film in films)
{
    titels_films.Add(film.Titel);
}
foreach (var titel in titels_films)
{
    Console.WriteLine(titel);
}


List<string> letters_titel = titels_films.Select(titel => titel.Substring(0,1)).ToList();
foreach (var letter in letters_titel)
{
    Console.WriteLine(letter);
}
letters_titel.Clear();
foreach(var titel in titels_films)
{
    letters_titel.Add(titel.Substring(0, 1));
}
foreach (var letter in letters_titel)
{
    Console.WriteLine(letter);
}





List<string> titels_horrorfilms = films
    .Where(f => f.Categorie.Equals("horror", StringComparison.CurrentCultureIgnoreCase))
    .Select(f => f.Titel)
    .Where(t => t.Length > 3)
    .ToList();
titels_horrorfilms.Clear();
foreach (var titel in titels_horrorfilms)
{
    Console.WriteLine(titel);
}
foreach (var film in films)
{
    if(film.Categorie.Equals("horror", StringComparison.CurrentCultureIgnoreCase) && film.Titel.Length >= 3)
    {
        titels_horrorfilms.Add(film.Titel);
    }
}
foreach(var titel in titels_horrorfilms)
{
    Console.WriteLine(titel);
}





