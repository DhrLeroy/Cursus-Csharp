using LINQ_Vluchten;

var vluchten = Data.GeefVluchten();





// LINQ-opdrachten:


// Oefening op Select (+ Distinct):

// 1. Alle bestemmingen van de vluchten

var bestemmingen = vluchten.Select(v => v.Naar.Naam).Distinct().ToList();

// 2. Alle maatschappijen van de vluchten

var maatschappijen = vluchten.Select(v => v.Maatschappij).Distinct().ToList();

// 3. Van alle vluchten: Vlucht op datum (volledige dag (maandag, dinsdag, woensdag, ...) dag (1, 2, 3, ...) volledige maand (januari, februari, ...) jaartal) van luchthaven (afk.) naar luchthaven (afk.)

var vluchten_data = vluchten.Select(v => $"{v.Naam} op {v.Datum.ToString("dddd d MMMM yyyy")} van {v.Van.Afkorting} naar {v.Naar.Afkorting}");

// Oefeningen op SelectMany:

// 4. Alle passagiers van alle vluchten

var passagiers = vluchten.SelectMany(v => v.Passagiers).ToList();

// Oefening op Where:

// 5. Alle vluchten van Brussels Airport (BRU)

var vluchten_van_BRU = vluchten.Where(v => v.Van.Afkorting.Equals("BRU", StringComparison.CurrentCultureIgnoreCase)).ToList() ;


// 6. Alle vluchten naar Schiphol (AMS)

var vluchten_naar_AMS = vluchten.Where(v => v.Naar.Afkorting.Equals("AMS", StringComparison.CurrentCultureIgnoreCase)).ToList();


// 7. Alle passagiers met een outlook.com e-mailadres

var passagiers_outlook = passagiers.Where(p => p.Emailadres.EndsWith("outlook.com", StringComparison.CurrentCultureIgnoreCase));


// 8. Alle vluchten met een reisduur langer dan 3 uur

var vluchten_langer_3_uur = vluchten.Where(v => v.Duurtijd.TotalHours > 3).ToList();

// 9. Alle vluchten die vertrekken in de maand augustus

var vluchten_augustus = vluchten.Where(v => v.Datum.Month == 8).ToList();


// 10. Alle vluchten met minder dan 30 passagiers

var vluchten_minder_30_passagiers = vluchten.Where(v => v.Passagiers.Count < 30).ToList();


// Oefening op Min, Max, Average, Count, Sum:


// 11. De duur van alle vluchten

var duurtijd_alle_vluchten = new TimeSpan(vluchten.Sum(v => v.Duurtijd.Ticks));

// of

var duurtijd_alle_vluchten_minuten = vluchten.Sum(v => v.Duurtijd.TotalMinutes);


// 12. De gemiddelde duur van alle vluchten

var gemiddelde_duur = new TimeSpan(Convert.ToInt64(vluchten.Average(v => v.Duurtijd.Ticks)));

// of

var gemiddelde_duur_minuten = vluchten.Average(v => v.Duurtijd.TotalMinutes);


// 13. De vlucht (naam van vertrek- en aankomstluchthaven) met de korste duur

var korste_duur = vluchten.Min(v => v.Duurtijd);

var kortste_vlucht = vluchten.First(v => v.Duurtijd == korste_duur);

var data_korste_vlucht = $"Vlucht van {kortste_vlucht.Van.Naam} naar {kortste_vlucht.Naar.Naam}";


// 14. Het aantal vluchten naar Rome (FCO)

var aantal_vluchten_rome = vluchten.Count(v => v.Naar.Afkorting.Equals("FCO", StringComparison.CurrentCultureIgnoreCase));


// 15. Het gemiddelde aantal passagiers per vlucht

var gemiddeld_aantal_passagiers = vluchten.Average(v => v.Passagiers.Count);


// 16. De naam van de vroegste vlucht

var datum_vroegste_vlucht = vluchten.Min(v => v.Datum);

var naam_vroegste_vlucht = vluchten.First(v => v.Datum == datum_vroegste_vlucht).Naam;



// 17. De naam van de hoogste luchthaven op zeeniveau

var alle_luchthavens = vluchten.Select(v => v.Van).Union(vluchten.Select(v => v.Naar)).ToList();

var hoogste_hoogte = alle_luchthavens.Max(l => l.HoogteZeeniveau);

var naam_hoogste_luchthaven = alle_luchthavens.First(l => l.HoogteZeeniveau == hoogste_hoogte).Naam;


// Oefening op OrderBy, ThenBy, OrderByDescending, ThenByDescending:

// 18. Alle vluchten gesorteerd op vertrekdatum (vroegste eerst)

var vluchten_volgens_vertrek_verleden_naar_toekomst = vluchten.OrderBy(v => v.Datum).ToList();


// 19. Alle vluchten gesorteerd op vertrekdatum (laatste eerst)

var vluchten_volgens_vertrek_toekomst_naar_verleden = vluchten.OrderByDescending(v => v.Datum).ToList();


// 20. Alle vluchten gesorteerd op vertrekdatum (vroegste eerst) en dan op naam van de luchthaven van vertrek (A-Z)

var vluchten_volgens_vertrek_vervolgens_naam_luchthaven_vertrek = vluchten.OrderBy(v => v.Datum).ThenBy(v => v.Van.Naam).ToList();

// 21. Alle passagiers gesorteerd op naam (A-Z)

var passagiers_volgens_naam = passagiers.OrderBy(p => p.Naam);


// 22. Alle passagiers gesorteerd op soort ticket (Business, Economy, ...), dan op naam (A-Z)

var passagiers_volgens_ticket_vervolgens_naam = passagiers.OrderBy(p => p.SoortTicket).ThenBy(p => p.Naam).ToList() ;


// 23. Alle vluchten gesorteerd op vertrekdatum (vroegste eerst) en dan op duur (kortste eerst)

var vluchten_volgens_vertrek_vervolgens_duur = vluchten.OrderBy(v => v.Datum).ThenBy(v => v.Duurtijd).ToList();


// Oefening op Concat, Union, Intersect, Except:

// 24. Alle vluchten van Brussels Airport (BRU) naar Schiphol (AMS)

var vluchten_van_BRU_naar_AMS = vluchten_van_BRU.Intersect(vluchten_naar_AMS).ToList();


// 25. Alle vluchten van Brussels Airport (BRU) of Schiphol (AMS) (zonder duplicaten)


var vluchten_van_AMS = vluchten.Where(v => v.Van.Afkorting.Equals("AMS", StringComparison.CurrentCultureIgnoreCase)).ToList();

var vluchten_van_BRU_of_AMS = vluchten_van_BRU.Union(vluchten_van_AMS).ToList();

// 26. Alle vluchten van Brussels Airport (BRU) die niet naar Schiphol (AMS) gaan

var vluchten_van_BRU_niet_naar_AMS = vluchten_van_BRU.Except(vluchten_naar_AMS).ToList();

// 27. Alle vluchten van Brussels Airport (BRU) die ook naar Schiphol (AMS) gaan

// idem als vraag 24


// 28. Alle passagiers van alle vluchten die naar Rome (FCO) of Madrid (MAD) gaan

var passagiers_naar_FCO_of_MAD = vluchten.Where(v => v.Naar.Afkorting.Equals("FCO", StringComparison.CurrentCultureIgnoreCase) || v.Naar.Afkorting.Equals("MAD", StringComparison.CurrentCultureIgnoreCase))
                                            .SelectMany(v => v.Passagiers)
                                            .Distinct()
                                            .ToList();

//of

var passagiers_naar_FCO = vluchten.Where(v => v.Naar.Afkorting.Equals("FCO", StringComparison.CurrentCultureIgnoreCase)).SelectMany(v => v.Passagiers);
var passagiers_naar_MAD = vluchten.Where(v => v.Naar.Afkorting.Equals("MAD", StringComparison.CurrentCultureIgnoreCase)).SelectMany(v => v.Passagiers);
passagiers_naar_FCO_of_MAD = passagiers_naar_FCO.Union(passagiers_naar_MAD).ToList();

// Oefening op Any/All:

// 29. Zijn er vluchten van Brussels Airport (BRU)?

var zijn_er_vluchten_van_BRU = vluchten.Any(v => v.Van.Afkorting.Equals("BRU", StringComparison.CurrentCultureIgnoreCase));


// 30. Zijn er vluchten van Brussels Airport (BRU) naar Schiphol (AMS)?

var zijn_er_vluchten_van_BRU_naar_AMS = vluchten.Any(v => v.Van.Afkorting.Equals("BRU", StringComparison.CurrentCultureIgnoreCase) && v.Naar.Afkorting.Equals("AMS", StringComparison.CurrentCultureIgnoreCase));

// of

// hergebruik of er vluchten van Brussels Airport (BRU) zijn uit vraag 29
// indien er geen vluchten van Brussels Airport zijn, is het zinloos om deze vraag nogmaals te berekenen
// idem voor vraag 31, 32 en 33

zijn_er_vluchten_van_BRU_naar_AMS = zijn_er_vluchten_van_BRU && vluchten.Any(v => v.Van.Afkorting.Equals("BRU", StringComparison.CurrentCultureIgnoreCase) && v.Naar.Afkorting.Equals("AMS", StringComparison.CurrentCultureIgnoreCase));

// 31. Zijn er vluchten van Brussels Airport (BRU) die vertrekken in de maand augustus?

var zijn_er_vluchten_van_BRU_in_augustus = vluchten.Any(v => v.Van.Afkorting.Equals("BRU", StringComparison.CurrentCultureIgnoreCase) && v.Datum.Month == 8);

// 32. Zijn er vluchten van Brussels Airport (BRU) met meer dan 30 passagiers?

var zijn_er_vluchten_van_BRU_met_meer_dan_30_passagiers = vluchten.Any(v => v.Van.Afkorting.Equals("BRU", StringComparison.CurrentCultureIgnoreCase) && v.Passagiers.Count > 30);

// 33. Vertrekken alle vluchten van Brussels Airport (BRU)?

var vertrekken_alle_vluchten_van_BRU = vluchten.All(v => v.Van.Afkorting.Equals("BRU", StringComparison.CurrentCultureIgnoreCase));

// 34. Gaan alle vluchten, die vertrekken van Brussels Airport (BRU), naar Schiphol (AMS)?

var gaan_alle_vluchten_die_van_BRU_vertrekken_naar_AMS = vluchten_van_BRU.All(v => v.Naar.Afkorting.Equals("AMS", StringComparison.CurrentCultureIgnoreCase));

// opgelet!! niet hetzelfde als

var gaan_alle_vluchten_van_BRU_naar_AMS = vluchten.All(v => v.Van.Afkorting.Equals("BRU", StringComparison.CurrentCultureIgnoreCase) && v.Naar.Afkorting.Equals("AMS", StringComparison.CurrentCultureIgnoreCase));

// 35. Hebben alle passgiers met een proton.me e-mailadres een business class ticket?

var hebben_alle_passgiers_protonemail_business_class = passagiers.Where(p => p.Emailadres.EndsWith("proton.me", StringComparison.CurrentCultureIgnoreCase)).All(p => p.SoortTicket.Equals("Business", StringComparison.CurrentCultureIgnoreCase));

// opgelet: zorg dat je niet een gelijkaardige fout maakt als in oefening 34 waarbij je zou kijken of alle passagiers een proton.me e-mailadres hebben en/of een Business class ticket hebben

// Oefening op GroupBy:

// 36. Groepeer de vluchten op vertrekluchthaven

var vluchten_per_vertrekluchthaven = vluchten.GroupBy(v => v.Van).ToList();


// 37. Groepeer de vluchten op aankomstluchthaven

var vluchten_per_aankomstluchthaven = vluchten.GroupBy(v => v.Naar).ToList();

// 38. Groepeer de vluchten op maatschappij

var vluchten_per_maatschappij = vluchten.GroupBy(v => v.Maatschappij).ToList();


// 39. Groepeer de vluchten op maand van vertrek

var vluchten_per_maand = vluchten.GroupBy(v => v.Datum.Month).ToList();


// 40. Groepeer de passagiers op soort ticket (Business, Economy, ...)

var passagiers_per_ticket = passagiers.GroupBy(p => p.SoortTicket).ToList();


// 41. Groepeer de passagiers op e-mailadresdomein (alles na het @-teken)

var passagiers_per_emaildomein = passagiers.GroupBy(p => p.Emailadres.Substring(p.Emailadres.IndexOf("@") + 1)).ToList();


// 42. Groepeer de vluchten op duurtijd (aantal uur, zonder minuten (bv. alle vluchten van minstens 1 uur, minstens 2 uur, ...)

var vluchten_per_duurtijd_uur = vluchten.GroupBy(v => v.Duurtijd.Hours).ToList();

// 43. Groepeer de vluchten op volledige dag (maandag, dinsdag, woensdag, ...) van de vertrekdatum

var vluchten_per_vertrekdag = vluchten.GroupBy(v => v.Datum.DayOfWeek).ToList();

// Oefeningen met meerdere LINQ-methoden:

// 44. Alle vluchten van Brussels Airport (BRU) gesorteerd op vertrekdatum (vroegste eerst)

var vluchten_BRU_volgens_vertrek = vluchten_van_BRU.OrderBy(v => v.Datum).ToList();


// 45. Alle vluchten van Brussels Airport (BRU) naar Schiphol (AMS) gesorteerd op vertrekdatum (vroegste eerst)

var vluchten_van_BRU_naar_AMS_volgens_vertrek = vluchten_van_BRU_naar_AMS.OrderBy(v => v.Datum).ToList();


// 46. Alle vluchten van Brussels Airport (BRU) naar Schiphol (AMS) met een reisduur langer dan 3 uur gesorteerd op aantal passagiers

var vluchten_van_BRU_naar_AMS_langer_dan_3_uur_volgens_aantal_passagiers = vluchten_van_BRU_naar_AMS.Where(v => v.Duurtijd.TotalHours > 3).OrderBy(v => v.Passagiers.Count).ToList();


// 47. De gemiddelde duur van alle vluchten van Brussels Airport (BRU)

var gemiddelde_duur_vluchten_BRU = new TimeSpan(Convert.ToInt64(vluchten_van_BRU.Average(v => v.Duurtijd.Ticks)));

// 48. Hebben alle luchthavens minstens één vlucht met een duur van minstens 2 uur?

var hebben_alle_luchthavens_minstens_1_vlucht_met_duur_van_minstens_2uur = alle_luchthavens
    .All(l => vluchten.Where(v => v.Van == l || v.Naar == l).Any(v => v.Duurtijd.TotalHours >= 2));


// 49. Heeft elke vlucht minstens één passagier die een e-mailadres heeft dat eindigt op outlook.com?

var heeft_elke_vlucht_minstens_1_passagier_outlookcom = vluchten.All(v => v.Passagiers.Any(p => p.Emailadres.EndsWith("outlook.com", StringComparison.CurrentCultureIgnoreCase)));


// 50. Selecteer dan namen (voornaam naam) van alle Business Class passagiers van alle vluchten van Brussels Airport (BRU) in de maand augustus, gesorteerd op naam (A-Z)

var namen_business_class_passagiers_van_BRU_in_augustus_volgens_naam = vluchten_van_BRU
    .Intersect(vluchten_augustus)
    .SelectMany(v => v.Passagiers)
    .Where(p => p.SoortTicket.Equals("Business", StringComparison.CurrentCultureIgnoreCase))
    .Distinct()
    .OrderBy(p => p.Naam)
    .Select(p => $"{p.Voornaam} {p.Naam}")
    .ToList();

// 51. De langste vlucht met minstens 10 First Class passagiers

var vluchten_minstens_10_firstclass = vluchten.Where(v => v.Passagiers.Count(p => p.SoortTicket.Equals("First Class", StringComparison.CurrentCultureIgnoreCase)) >= 10);

var langste_duur_vluchten_minstens_10_firstclass = vluchten_minstens_10_firstclass.Max(v => v.Duurtijd);

var langste_vlucht_minstens_10_firstclass = vluchten_minstens_10_firstclass.First(v => v.Duurtijd == langste_duur_vluchten_minstens_10_firstclass);

Console.WriteLine();

Console.WriteLine();