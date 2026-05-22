var einde_schooljaar = new DateTime(DateTime.Now.Year, 6, 30, 12, 0, 0);

var verschil = einde_schooljaar - DateTime.Now;

Console.WriteLine($"Nog {Math.Round(verschil.TotalSeconds,0)} seconden tot de vakantie!");