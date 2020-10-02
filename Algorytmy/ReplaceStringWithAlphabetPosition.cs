using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorytmy
{
    class ReplaceStringWithAlphabetPosition
    {
    public static string AlphabetPosition(string text)
        {
            return string.Join("", text.ToLower()
                .Where(char.IsLetter)
                .Select(x => x - 'a' + 1));
        }
    }


   
}
