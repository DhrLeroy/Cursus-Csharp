/*Laat de gebruiker een woord ingeven en vervang alle middelste letters (dus behalve de eerste de laatste) door *-tjes
 * en in hoofdletters.
 
Bv.

Woord: Hallo
Gemaskeerd: H***O
 */


Console.Write("Woord: ");

string woord = Console.ReadLine();

Console.Write("Gemaskeerd: ");

string sterretjes = "";
for(int i = 0; i < woord.Length-2; i++)
{
    sterretjes += "*";
}

Console.Write($"{woord.Substring(0, 1).ToUpper()}{sterretjes}{woord.Substring(woord.Length - 1, 1).ToUpper()}");