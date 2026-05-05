using Les_8___DateTime_TimeSpan;
/*
var geboortedatum = new DateTime(1993, 4, 15);

var vandaag = DateTime.Now;

// dag van de week
Console.WriteLine(geboortedatum.DayOfWeek);

// dag van het jaar
Console.WriteLine(geboortedatum.DayOfYear);

//schrikkeljaar
Console.WriteLine(DateTime.IsLeapYear(1993));

// datum binnen 1 week
var binnen1week = vandaag.AddDays(7);
Console.WriteLine(binnen1week);

var binnen20uur = vandaag.AddHours(20);
Console.WriteLine(binnen20uur);

var gisteren = vandaag.AddDays(-1);
Console.WriteLine(gisteren);

Console.WriteLine();

var februari29 = new DateTime(2024, 2, 29);
Console.WriteLine(februari29.AddHours(30));
Console.WriteLine(februari29.AddDays(1));
Console.WriteLine(februari29.AddYears(1));
Console.WriteLine(februari29.AddYears(1));
Console.WriteLine(februari29.AddDays(365));

var afspraak = new DateTime(2026,4,29,16,0,0);

var tijdTotAfspraak = afspraak - DateTime.Now;

Console.WriteLine(tijdTotAfspraak.TotalMinutes);
Console.WriteLine(tijdTotAfspraak.Minutes);

Console.WriteLine(vandaag.Add(tijdTotAfspraak));

var lesuur = new TimeSpan(0, 50, 0);
var duurInformatica = lesuur * 4;

Console.WriteLine(duurInformatica);

var d1 = new DateTime(1990, 1, 4);
var d2 = new DateTime(2017, 3, 7);

if(d2 < d1)
{
    Console.WriteLine($"{d2} is vroeger dan {d1}");
}


var d3 = DateTime.Today;
var d4 = DateTime.Now;

if(d3 == d4)
    Console.WriteLine("Gelijk");
else
    Console.WriteLine("Verschillend");


*/


var vandaag = DateTime.Now;

Console.WriteLine(vandaag.ToString("dddd d MMMM yyyy o\\m h:mm:ss"));

if (vandaag.DayOfWeek == DayOfWeek.Sunday || vandaag.DayOfWeek == DayOfWeek.Saturday)
    Console.WriteLine("Weekend");
else
    Console.WriteLine("Werkdag");

var d = new DateTime(9999, 12, 31, 23, 59, 59);
d.AddHours(1);
























/*using Les_8___DateTime_TimeSpan;

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
*/