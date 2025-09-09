/*Laat de gebruiker een woord ingeven en vervang alle middelste letters (dus behalve de eerste de laatste) door *-tjes
 * en in hoofdletters.
 
Bv.

Woord: Hallo
Gemaskeerd: H***O
 */


Console.WriteLine();

string wachtwoord = "MyVerySecurePassword123!";
string input;
do
{
    Console.Write("Geef het wachtwoord in: ");
    input = Console.ReadLine();
} while (wachtwoord != input);
