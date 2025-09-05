Console.Write("x: ");
var x = Convert.ToSingle(Console.ReadLine());
Console.Write($"Functiewaarde x^4-3x^3+1x/4-9 = {Math.Pow(x, 4) - (3 * Math.Pow(x, 3)) + (x * 0.25) - 9}");