using System;
using System.Collections.Generic;
using System.Text;

namespace Algorytmy
{
    class IsNumberSquare
    {
        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }
    }
}
