Console.Write("Geef uw geboortedatum in.\nDag: ");
var dag = Convert.ToInt32(Console.ReadLine());
Console.Write("Maand: ");
var maand = Convert.ToInt32(Console.ReadLine());
Console.Write("Jaar: ");
var jaar = Convert.ToInt32(Console.ReadLine());

var geboorte = new DateTime(jaar, maand, dag);

if (geboorte > DateTime.Today)
{
    Console.WriteLine("Geboorte in de toekomst niet mogelijk");
}
else
{
    var leeftijd = DateTime.Today.Year - jaar;
    var verjaardag = new DateTime(DateTime.Today.Year, maand, dag);
    if (verjaardag > DateTime.Today)
        leeftijd--;
    Console.WriteLine($"{leeftijd} jaar.");
}