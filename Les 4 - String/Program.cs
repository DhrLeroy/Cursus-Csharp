string tekst = "ABcdefa";


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


