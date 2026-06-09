using LINQ_Vluchten;

var vluchten = Data.GeefVluchten();


// LINQ-opdrachten:


// Oefening op Select (+ Distinct):

// 1. Alle bestemmingen van de vluchten

// 2. Alle maatschappijen van de vluchten

// 3. Van alle vluchten: Vlucht op datum (volledige dag (maandag, dinsdag, woensdag, ...) dag (1, 2, 3, ...) volledige maand (januari, februari, ...) jaartal) van luchthaven (afk.) naar luchthaven (afk.)


// Oefeningen op SelectMany:

// 4. Alle passagiers van alle vluchten


// Oefening op Where:

// 5. Alle vluchten van Brussels Airport (BRU)


// 6. Alle vluchten naar Schiphol (AMS)


// 7. Alle passagiers met een outlook.com e-mailadres


// 8. Alle vluchten met een reisduur langer dan 3 uur


// 9. Alle vluchten die vertrekken in de maand augustus


// 10. Alle vluchten met minder dan 30 passagiers


// Oefening op Min, Max, Average, Count, Sum:


// 11. De duur van alle vluchten


// 12. De gemiddelde duur van alle vluchten


// 13. De vlucht (naam van vertrek- en aankomstluchthaven) met de korste duur


// 14. Het aantal vluchten naar Rome (FCO)


// 15. Het gemiddelde aantal passagiers per vlucht


// 16. De naam van de vroegste vlucht


// 17. De naam van de hoogste luchthaven op zeeniveau


// Oefening op OrderBy, ThenBy, OrderByDescending, ThenByDescending:

// 18. Alle vluchten gesorteerd op vertrekdatum (vroegste eerst)


// 19. Alle vluchten gesorteerd op vertrekdatum (laatste eerst)


// 20. Alle vluchten gesorteerd op vertrekdatum (vroegste eerst) en dan op naam van de luchthaven van vertrek (A-Z)


// 21. Alle passagiers gesorteerd op naam (A-Z)


// 22. Alle passagiers gesorteerd op soort ticket (Business, Economy, ...), dan op naam (A-Z)


// 23. Alle vluchten gesorteerd op vertrekdatum (vroegste eerst) en dan op duur (kortste eerst)


// Oefening op Concat, Union, Intersect, Except:

// 24. Alle vluchten van Brussels Airport (BRU) en Schiphol (AMS)


// 25. Alle vluchten van Brussels Airport (BRU) of Schiphol (AMS) (zonder duplicaten)


// 26. Alle vluchten van Brussels Airport (BRU) die niet naar Schiphol (AMS) gaan


// 27. Alle vluchten van Brussels Airport (BRU) die ook naar Schiphol (AMS) gaan


// 28. Alle passagiers van alle vluchten die naar Rome (FCO) of Madrid (MAD) gaan


// Oefening op Any/All:

// 29. Zijn er vluchten van Brussels Airport (BRU)?


// 30. Zijn er vluchten van Brussels Airport (BRU) naar Schiphol (AMS)?


// 31. Zijn er vluchten van Brussels Airport (BRU) die vertrekken in de maand augustus?


// 32. Zijn er vluchten van Brussels Airport (BRU) met meer dan 30 passagiers?


// 33. Vertrekken alle vluchten van Brussels Airport (BRU)?


// 34. Gaan alle vluchten, die vertrekken van Brussels Airport (BRU), naar Schiphol (AMS)?


// 35. Hebben alle passgiers met een proton.me e-mailadres een business class ticket?


// Oefening op GroupBy:

// 36. Groepeer de vluchten op vertrekluchthaven


// 37. Groepeer de vluchten op aankomstluchthaven


// 38. Groepeer de vluchten op maatschappij


// 39. Groepeer de vluchten op maand van vertrek


// 40. Groepeer de passagiers op soort ticket (Business, Economy, ...)


// 41. Groepeer de passagiers op e-mailadresdomein (alles na het @-teken)


// 42. Groepeer de vluchten op duurtijd (aantal uur, zonder minuten (bv. alle vluchten van minstens 1 uur, minstens 2 uur, ...)


// 43. Groepeer de vluchten op volledige dag (maandag, dinsdag, woensdag, ...) van de vertrekdatum


// Oefeningen met meerdere LINQ-methoden:

// 44. Alle vluchten van Brussels Airport (BRU) gesorteerd op vertrekdatum (vroegste eerst)


// 45. Alle vluchten van Brussels Airport (BRU) naar Schiphol (AMS) gesorteerd op vertrekdatum (vroegste eerst)


// 46. Alle vluchten van Brussels Airport (BRU) naar Schiphol (AMS) met een reisduur langer dan 3 uur gesorteerd op aantal passagiers


// 47. De gemiddelde duur van alle vluchten van Brussels Airport (BRU)


// 48. Hebben alle luchthavens minstens één vlucht met een duur van minstens 2 uur?


// 49. Heeft elke vlucht minstens één passagier die een e-mailadres heeft dat eindigt op outlook.com?


// 50. Selecteer dan namen (voornaam naam) van alle Business Class passagiers van alle vluchten van Brussels Airport (BRU) in de maand augustus, gesorteerd op naam (A-Z)


// 51. De langste vlucht met minstens 10 First Class passagiers