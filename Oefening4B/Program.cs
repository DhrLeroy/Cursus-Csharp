/* Laat de gebruiker een zin intypen, waarbij je de eerste zin in hoofdletters plaats en de rest in kleine letters.

Bv.
Dit is een Zin

wordt

DIT is een zin.

*/

string zin = Console.ReadLine();

string aangepast = zin.Substring(0, zin.IndexOf(" ")).ToUpper() + zin.Substring(zin.IndexOf(" ")).ToLower();

Console.WriteLine(aangepast);