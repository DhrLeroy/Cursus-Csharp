using System;

class Program
{
    static void Main()
    {
        // Input startdatum
        Console.Write("Jaartal: ");
        var jaar = Convert.ToInt32(Console.ReadLine());
        Console.Write("Maand: ");
        var maand = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dag: ");
        var dag = Convert.ToInt32(Console.ReadLine());
        DateTime startDatum = new DateTime(jaar,maand,dag);

        // Input startsalaris
        Console.Write("Geef het startsalaris: ");
        double salaris = double.Parse(Console.ReadLine());

        DateTime vandaag = DateTime.Today;

        // Controle: datum mag niet in de toekomst liggen
        if (startDatum > vandaag)
        {
            Console.WriteLine("Startdatum mag niet in de toekomst liggen");
            return;
        }

        DateTime huidigeDatum = startDatum;

        Console.WriteLine("\nSalarisverhogingen:");

        // Elke 5 maanden een verhoging
        while (huidigeDatum.AddMonths(5) <= vandaag)
        {
            // Ga 5 maanden vooruit
            huidigeDatum = huidigeDatum.AddMonths(5);

            // Salaris verhogen met 5%
            salaris *= 1.02;

            // Output
            Console.WriteLine(
                $"{huidigeDatum:dd MMMM yyyy} -> {salaris:F2} euro"
            );
        }
    }
}