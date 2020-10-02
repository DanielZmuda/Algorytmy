using System;
using System.Collections.Generic;
using System.Text;

namespace Algorytmy
{
    class IsNumberPrime
    {
        public static bool IsPrime(int n)
        {
            if (n == 2 || n == 3 || n== 5 || n == 7 ) { return true; }
            if (n == -1 || n==1) { return false; }
            if (n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0)
            {
                return true;
            }
            else
            {
                return false;
            };
        }
    }
}
