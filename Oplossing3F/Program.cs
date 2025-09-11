Console.Write("Geef een getal in: ");
int getal = Convert.ToInt32(Console.ReadLine());

var tafel = new float[10];
for (int i = 0; i < tafel.Length; i++)
{
    tafel[i] = getal * (i + 1);
}
for (int i = 0; i < tafel.Length; i++)
{
    Console.WriteLine(tafel[i]);
    tafel[i] = tafel[i] / 2;
}
foreach (float i in tafel)
{
    Console.WriteLine(i);
}