var namen = new List<string>()
{
    "Bert",
    "Javis",
    "Ellie",
    "Mo"
};



var eerste_letters = new List<string>();
foreach (var naam in namen)
{
    eerste_letters.Add(naam.Substring(0, 1));
}
eerste_letters = namen.Select(naam => naam.Substring(0, 1)).ToList();

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