using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursie_faculteit
{
    public static class Faculteit
    {
        public static int BerekenFaculteit(int n)
        {
            if (n == 1)
                return 1;
            Console.WriteLine($"Start met berekenen van faculteit {n}");
            return n * BerekenFaculteit(n - 1);
        }
    }
}
