using System;
using System.Collections.Generic;
using System.Text;

namespace Algorytmy
{
    class ReapeatString
    {
        public static string repeatStr(int n, string s)
        {
            string returnString="";
            for(int i=0; i<n;i++)
            {
                returnString += s;
            }
            return returnString;
        }

        //public static string repeatStr(int n, string s)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    for (int i = 0; i < n; i++)
        //    {
        //        builder.Append(s);
        //    }
        //    return builder.ToString();
        //}

        //public static string repeatStr(int n, string s)
        //{
        //    return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
        //}
    }
}
