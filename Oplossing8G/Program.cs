var nu = DateTime.Now;

var maanden = 12 - nu.Month;

var beginVolgendeMaand = new DateTime(nu.Year, nu.Month, 1).AddMonths(1);

var verschilTotVolgendeMaand = beginVolgendeMaand - nu;

Console.WriteLine($"Het is nog {maanden} maanden, " +
    $"{verschilTotVolgendeMaand.Days} dagen, {verschilTotVolgendeMaand.Hours} uren, " +
    $"{verschilTotVolgendeMaand.Minutes} minuten en {verschilTotVolgendeMaand.Seconds} seconden tot Nieuwjaar!");

