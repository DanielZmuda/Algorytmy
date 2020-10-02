using System;
using System.Collections.Generic;
using System.Text;

namespace Algorytmy
{
    class AreStringsAnagrams
    {

        public static bool AreAnagrams(string word1, string word2)
        {
           char[] char1 = word1.ToLower().ToCharArray();
           char[] char2 = word2.ToLower().ToCharArray();

            Array.Sort(char2);
            Array.Sort(char1);

            word1 = new string(char1);
            word2 = new string(char2);

            if (word1 == word2) return true;
            return false;
        }
    }
}
