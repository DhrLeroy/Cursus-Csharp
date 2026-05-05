using Toets_LINQ_1;

var planeten = Data.AllePlaneten();

var planeten_natuurlijke_manen = planeten.
    Where(p => p.Satelieten.All(s => s.Type == "Maan") && p.Satelieten.Count > 0)
    .Select(p => p.Naam);

var satellieten = planeten.SelectMany(p => p.Satelieten).ToList();

int jaartal_vroegste_ruimtesonde = satellieten
    .Where(s => s.Type == "Kunstmatig")
    .Min(s => s.LanceerJaar);

var naam_vroegste_ruimtesonde = satellieten.Where(s => s.LanceerJaar == jaartal_vroegste_ruimtesonde).Select(r => r.Naam);

var aarde = planeten.Where(p => p.Naam == "Aarde").ToList()[0];

var gemiddeldeTempPlaneten = planeten
    .Where(p => p.AfstandTotZon <= aarde.AfstandTotZon)
    .Average(p => p.TemperatuurGemiddeld);

var satt_atm = satellieten.Any(s => s.HeeftAtmosfeer);

var bewoon_nat_satt = satellieten.Count(s => s.IsBewoonbaar && s.Type == "Maan");

var planeten_met_ringen = planeten.Count(p => p.HeeftRingen);

var planeten_met_sat = planeten.
    OrderByDescending(p => p.Satelieten.Count)
    .ThenBy(p => p.Naam)
    .Select(p => $"{p.Naam}: {p.Satelieten.Count} satellieten");

var planeten_gewicht = planeten
    .Select(p => $"{p.Naam}: {p.Satelieten.Sum(s => s.Massa) + p.Massa * 10000} x 10^20 kg")
    .ToList();

var planeten_temp_afst = planeten
    .Where(p => p.Type == "Terrestrisch")
    .OrderBy(p => p.TemperatuurGemiddeld - (p.TemperatuurGemiddeld % 100))
    .ThenByDescending(p => p.AfstandTotZon)
    .Select(p => $"{p.Naam}.");