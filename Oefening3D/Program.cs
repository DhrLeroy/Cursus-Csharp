/* d.	Maak een lijst van getallen. Laat automatisch hier alle getallen van 278 t.e.m. 300 in steken. 
 * Overloop vervolgens deze lijst en tel deze getallen bij elkaar op.
 * */

List<int> getallen = new List<int>();
for (int i = 278; i <= 300; i++)
{
    getallen.Add(i);
}

var som = 0;

foreach (var getal in getallen)
    som += getal;

Console.WriteLine($"Som = {som}");