Console.Write("Lengte (m): ");
var l = Convert.ToSingle(Console.ReadLine());
Console.Write("Gewicht (kg): ");
var g = Convert.ToSingle(Console.ReadLine());

var bmi = g / (l * l);

Console.WriteLine($"BMI = {bmi}");