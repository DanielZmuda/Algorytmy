using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorytmy
{
    class CreatePhoneNumber
    {
        public static string Create(int[] numbers)
        {
            StringBuilder builder= new StringBuilder();

            var returnString = string.Join("", numbers);

            builder.Append("(" + returnString.Substring(0, 3) + ") " + returnString.Substring(3,3) + "-" + returnString.Substring(6,4));

            return builder.ToString();

        }


        //public static string CreatePhoneNumber(int[] numbers)
        //{
        //    return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        //}
    }
}
