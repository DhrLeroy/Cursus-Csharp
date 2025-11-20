using Les_8___DateTime_TimeSpan;

DateTime geboortedatum = new DateTime(2009, 1, 18);

if(geboortedatum.DayOfWeek == DayOfWeek.Sunday)
{
    Console.WriteLine("Ik werd geboren op een zondag");
}

DateTime schrikkeldatum = new DateTime(2023, 2, 28);

if (DateTime.IsLeapYear(schrikkeldatum.Year))
{
    Console.WriteLine("Schrikkeljaar!");
}

var vandaag = DateTime.Now;

var sindsGeboorte = vandaag - geboortedatum;


var lesuur = new TimeSpan(0, 50, 0);

var lesuur1 = DateTime.Today + new TimeSpan(8, 40, 0);
var lesuur2 = lesuur1 + lesuur;

Console.WriteLine(DateTime.Now.ToString("dddd, d MMMM yy HHumm"));



Console.WriteLine("\n\n\n");


var gebeurtenis = new DateTime(2000, 1, 2);

var toekomst = DateTime.Now.Add(DateTime.Now - gebeurtenis);

Console.WriteLine(toekomst.ToString("d"));
