using System;

namespace Algorytmy
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( AreStringsAnagrams.AreAnagrams("heloo", "hi"));
            Console.WriteLine(AreStringsAnagrams.AreAnagrams("Listen", "Silent"));
            Console.WriteLine(AreStringsAnagrams.AreAnagrams("heloo", "hi"));
        }
    }
}
