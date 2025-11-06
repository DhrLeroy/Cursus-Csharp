using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_8___DateTime_TimeSpan
{
    using System;

    public class LeeftijdBerekenen
    {
        public static void Bereken()
        {
            DateTime reference = new DateTime(2025, 11, 6); // referentiedatum
            DateTime[] births = new[]
            {
            new DateTime(2000, 2, 29),  // schrikkeldaggeval
            new DateTime(1999, 11, 7),  // verjaardag morgen (niet bereikt op ref)
            new DateTime(1999, 11, 6),  // verjaardag vandaag (bereikt)
            new DateTime(1980, 12, 31)  // gewoon voorbeeld
        };

            foreach (var b in births)
            {
                double totalDays = (reference - b).TotalDays;
                double approxYears = totalDays / 365.25;          // benadering
                int approxTrunc = (int)approxYears;               // afkappen
                int approxRound = (int)Math.Round(approxYears);   // afronden
                int correct = CalculateAge(b, reference);         // juiste methode

                Console.WriteLine($"Geboren: {b:yyyy-MM-dd}");
                Console.WriteLine($"  TotalDays = {totalDays:N0}");
                Console.WriteLine($"  approxYears = {approxYears:F6}");
                Console.WriteLine($"  approx (trunc) = {approxTrunc}");
                Console.WriteLine($"  approx (round) = {approxRound}");
                Console.WriteLine($"  correct age    = {correct}");
                Console.WriteLine();
            }
        }
        static int CalculateAge(DateTime birthDate, DateTime refDate)
        {
            int age = refDate.Year - birthDate.Year;
            if (refDate.Month < birthDate.Month || (refDate.Month == birthDate.Month && refDate.Day < birthDate.Day))
                age--;
            return age;
        }
    }

}
