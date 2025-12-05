var aantal_leverdagen = DateTime.Now.Hour < 22 ? 2 : 3;

var leverdatum = DateTime.Today;

while(aantal_leverdagen > 0)
{
    leverdatum = leverdatum.AddDays(1);
    if(leverdatum.DayOfWeek != DayOfWeek.Saturday && leverdatum.DayOfWeek != DayOfWeek.Sunday)
        aantal_leverdagen--;
}

Console.WriteLine($"Verwachte leverdatum: {leverdatum.ToString("dddd, d ")}");