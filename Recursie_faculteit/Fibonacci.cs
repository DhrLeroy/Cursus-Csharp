using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursie
{
    internal static class Fibonacci
    {
        public static int NdeFibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return NdeFibonacci(n - 2) + NdeFibonacci(n - 1);
        }
    }
}
