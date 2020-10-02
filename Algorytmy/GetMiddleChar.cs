using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorytmy
{
    class GetMiddleChar
    {
        public static string GetMiddle(string s)
        {
            char[] charArray = s.ToCharArray();
            int divMath = s.Length % 2;
            if (divMath  != 0)
            {
                return s[s.Length / 2].ToString();
            }
            return s[s.Length / 2].ToString() + s[s.Length / 2 - 1].ToString();
        }

        //public static string GetMiddle(string s)
        //{
        //    return string.IsNullOrEmpty(s)
        //        ? s
        //        : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
        //}
    }
}
