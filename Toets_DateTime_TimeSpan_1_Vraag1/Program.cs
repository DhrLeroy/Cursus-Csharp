Console.Write("Dag: ");
int dag = Convert.ToInt32(Console.ReadLine());
Console.Write("Maand: ");
int maand = Convert.ToInt32(Console.ReadLine());
Console.Write("Jaar: ");
int jaar = Convert.ToInt32(Console.ReadLine());

var datum = new DateTime(jaar, maand, dag);

var tijd_verstreken = DateTime.Now - datum;

var dagen = tijd_verstreken.Days;
var uren = tijd_verstreken.Hours;
var minuten = tijd_verstreken.Minutes;
var seconden = tijd_verstreken.Seconds;

Console.WriteLine($"{dagen} dag{(dagen > 1 ? "en" : "")}, {uren} {(uren > 1 ? "uren" : "uur")}, {minuten} {(minuten > 1 ? "minuten" : "minuut")} en {seconden} {(seconden > 1 ? "seconden" : "seconde")}");