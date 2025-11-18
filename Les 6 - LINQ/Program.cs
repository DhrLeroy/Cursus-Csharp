var namen = new List<string>()
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
Console.WriteLine($"Omtrekken cirkels: {string.Join("  |  ", omtrekken_cirkels)}");