﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorytmy
{
//    Write a function that takes an integer as input, 
//    and returns the number of bits that are equal 
//    to one in the binary representation of that number.
    //You can guarantee that input is non-negative.

//Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case

    class BitCounting
    {

        public static int CountBits(int n)
        {
            var number = Convert.ToString(n, 2);
            return number.Count(x => x == '1');
        }
    }
}
