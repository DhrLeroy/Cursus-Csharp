List<string> huisdieren = new List<string>();

for (int i = 0; i < 3; i++)
{
    Console.Write("Geef een naam van jouw huisdier op: ");
    huisdieren.Add(Console.ReadLine());
}

Console.Write("Jouw huisdieren zijn: ");
foreach (var huisdier in huisdieren)
{
    Console.Write($"{huisdier} ");
}