Console.Write("Geef a in: ");
var a = Convert.ToInt32(Console.ReadLine());
Console.Write("Geef b in: ");
var b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Som: {a} + {b} = {a + b}");
Console.WriteLine($"Verschil: {a} - {b} = {a - b}");
Console.WriteLine($"Product: {a} x {b} = {a * b}");
Console.WriteLine($"Quotiënt: {a} / {b} = {a / Convert.ToSingle(b)}");