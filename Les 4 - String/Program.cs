string tekst = "\t\tDeze les is leuk.       ";

string tekst_zonder_begineind_spaties = tekst.Trim();

string tekst_kleine_letters = tekst.ToLower();
string tekst_hoofdletters = tekst.ToUpper();

string tekst_zonder_a = tekst.Replace("a", "y", StringComparison.CurrentCultureIgnoreCase);

var woorden = tekst.Split(" ");
string terug_de_zin = string.Join(" ", woorden);

string metXOpEinde = tekst.Insert(tekst.Length, "X");
string metXInBegin = tekst.Insert(0, "X");


int laatste_positie_spatie = tekst.LastIndexOf(" ");

int eerst_positie_spatie = tekst.IndexOf(" ");
string tweede_woord = tekst.Substring(eerst_positie_spatie+1);
tweede_woord = tweede_woord.Substring(0, tweede_woord.IndexOf(" "));
tweede_woord = tekst.Substring(eerst_positie_spatie + 1, tekst.IndexOf(" ", tekst.IndexOf(" ") + 1) - eerst_positie_spatie-1);
tweede_woord = woorden[1];


bool gelijk_abcdef = tekst.Equals("abcdef", StringComparison.CurrentCultureIgnoreCase);

bool start_met_a = tekst.StartsWith("a", System.StringComparison.CurrentCultureIgnoreCase);
bool eindigt_op_f = tekst.EndsWith("F", StringComparison.CurrentCultureIgnoreCase);

bool bevat_CD = tekst.Contains("CD", StringComparison.CurrentCultureIgnoreCase);


































/*string tekst = "ik speel graag videoGame";

var woorden = tekst.Split(" ");
for(int i = 0; i < woorden.Length; i++)
{
    woorden[i] = woorden[i].Substring(0, 1).ToUpper() + woorden[i].Substring(1);
}

string alles_woorden_met_hoofdletter = string.Join(" ", woorden);
Console.WriteLine(alles_woorden_met_hoofdletter);

var tekst_zonder_iI = tekst.Replace("i", "1", StringComparison.CurrentCultureIgnoreCase);


var x = string.Join(", ", tekst.Split(" "));

var tekst_zonder_witruimtes_voor_of_na = tekst.Trim();

var alles_kleine_letters = tekst.ToLower();
var alles_hoofdletters = tekst.ToUpper();

var eerste_woord = tekst.Substring(0, tekst.IndexOf(" "));
var tweede_woord = tekst.Substring(tekst.IndexOf(" ")+1, 
    tekst.IndexOf(" ", tekst.IndexOf(" ")) - tekst.IndexOf(" ")+1);

tweede_woord = tekst.Split(" ")[1];

//var woorden = tekst.Split(" ");

foreach(var woord in woorden)
    Console.WriteLine(woord);


tekst = tekst.Insert(0, "Weetje: ");


tekst.LastIndexOf("g", StringComparison.CurrentCultureIgnoreCase);

tekst.IndexOf("Speel", StringComparison.CurrentCultureIgnoreCase);

string code = "CDFABDJFFCAKJFDE";

int positie_van_eerste_a = code.IndexOf("A", StringComparison.CurrentCultureIgnoreCase);
int positie_van_tweede_a = code.IndexOf("A", code.IndexOf("A")+1);

bool is_gelijk = tekst.Equals("Ik speel graag videogame", StringComparison.CurrentCultureIgnoreCase);


bool eindigt_op_Game = tekst.EndsWith("Game", StringComparison.CurrentCultureIgnoreCase);
bool begint_met_ik = tekst.StartsWith("ik", StringComparison.CurrentCultureIgnoreCase);


int aantal_tekens = tekst.Count();


bool bevat_a = tekst.Contains("Videogame", StringComparison.CurrentCultureIgnoreCase);

Console.WriteLine();
*/

















/*string tekst = "ABcdefa";


bool zit_b_in_tekst = tekst.Contains("b", StringComparison.CurrentCultureIgnoreCase);

bool tekst_begint_met_ab = tekst.StartsWith("ab"
    , StringComparison.CurrentCultureIgnoreCase);

bool tekst_eindigt_met_ef = tekst.EndsWith("ef",
    StringComparison.CurrentCultureIgnoreCase);

bool is_gelijk_aan_abcdef = tekst.Equals("abcdef",
    StringComparison.CurrentCultureIgnoreCase);


int positie_van_A = tekst.IndexOf("A",
    StringComparison.CurrentCultureIgnoreCase);
int positie_van_x = tekst.IndexOf("x",
    StringComparison.CurrentCultureIgnoreCase);
int laatste_positie_van_a = tekst.LastIndexOf("a");


var tekst_met_x = tekst.Insert(0, "x");
var tekst_zonder_x = tekst.Remove(0);

int lengte_van_tekst = tekst.Length;

var tekst_zonder_a = tekst.Replace("a", " ",
    StringComparison.CurrentCultureIgnoreCase);

string[] woorden = "Dit is een zin".Split(" ");

string letters234Bcd = tekst.Substring(1, 3);

string eersteLetter = tekst.Substring(0, 1);

string laatsteLetter = tekst.Substring(tekst.Length - 1, 1);

Console.WriteLine(letters234Bcd);
Console.WriteLine(eersteLetter);
Console.WriteLine(laatsteLetter);

string woord = "Hond";
string middelsteLetter = woord.Substring(woord.Length / 2, 1);
Console.WriteLine(middelsteLetter);

string alles_behalve_eerste_letter = tekst.Substring(1);

string HOOFDLETTERS = tekst.ToUpper();
string kleineletters = tekst.ToLower();

string lange_tekst = "\tHallo, ik ben       \n    gelukkig!      ";
Console.WriteLine($"START{lange_tekst.Trim()}EIND");

string zonder_spaties = lange_tekst.Replace("\n", "");
Console.WriteLine(zonder_spaties);


*/