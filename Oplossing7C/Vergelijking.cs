using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oplossing7C
{
    public class Vergelijking
    {
        public float CoefA { get; set; }
        public float CoefB { get; set; }
        public float CoefC { get; set; }

        public Vergelijking(float coefA, float coefB, float coefC)
        {
            CoefA = coefA;
            CoefB = coefB;
            CoefC = coefC;
        }

        public void ToonVergelijking()
        {
            List<string> onderdelen = new List<string>();
            if (CoefA != 0) { 
                onderdelen.Add($"{CoefA}x²");
            }
            if (CoefB != 0) {
                if (CoefB < 0)
                    onderdelen.Add("-");
                else if(onderdelen.Count > 0)
                    onderdelen.Add("+");
                onderdelen.Add($"{Math.Abs(CoefB)}x");
            }
            if (CoefC != 0)
            {
                if (CoefC < 0)
                    onderdelen.Add("-");
                else if (onderdelen.Count > 0)
                    onderdelen.Add("+");
                onderdelen.Add($"{Math.Abs(CoefC)}");
            }
            Console.WriteLine(string.Join(" ", onderdelen));
        }

        public float[] GeefNulpunten()
        {
            float[] nulpunten;
            if (CoefA != 0) {
                var discrimant = (CoefB * CoefB) - (4 * CoefA * CoefC);
                if(discrimant >= 0)
                {
                    nulpunten = new float[2];
                    var x1 = (-1 * (CoefB) - Math.Sqrt(discrimant)) / (2 * CoefA);
                    var x2 = (-1 * (CoefB) + Math.Sqrt(discrimant)) / (2 * CoefA);
                    nulpunten[0] = x1;
                    nulpuntenen[1] = x2;
                }else if(discrimant == 0)
                {
                    nulpunten = new float[1];
                    var x1 = (-1 * CoefB) / (2 * CoefA);
                    nulpunten[0] = x1;
                }
                else
                {
                    nulpunten = new float[0];
                }

            }
            else if(CoefB != 0) {
            {
                nulpunten = new float[1];
                var nulpunt = ((-1) * CoefC) / CoefB;
                nulpunten[0] = nulpunt;
            }
            else
            {
                if(CoefC == 0)
                {
                    nulpunten = new float[201];
                    nulpunten[0] = 0;
                    for (int i = 1; i <= 100; i++)
                    {
                        nulpunten[i] = i;
                        nulpunten[100 + 1] = i * (-1);
                    }
                }
                else
                {
                    nulpunten = new float[0];
                }
            }
            return nulpunten;
        }
    }
}
