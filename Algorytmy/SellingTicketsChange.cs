using System;
using System.Collections.Generic;
using System.Text;

namespace Algorytmy
{
    class SellingTicketsChange
    {
// The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line.
//Each of them has a single 100, 50 or 25 dollar bill.An "Avengers" ticket costs 25 dollars.
//Vasya is currently working as a clerk.
//He wants to sell a ticket to every single person in this line.

//Can Vasya sell a ticket to every person and give change if he initially has no money and sells the tickets strictly in the order people queue?

//Return YES, if Vasya can sell a ticket to every person and give change with the bills he has at hand at that moment.Otherwise return NO

        public static string Tickets(int[] peopleInLine)
        {
            int vasyaMoney = 0;
            for(int i=0; i<peopleInLine.Length; i++)
            {
                if (vasyaMoney < 0) return "NO";

                switch(peopleInLine[i]){
                    case 25:
                        vasyaMoney += 25;
                        break;
                    case 50:
                        vasyaMoney -= 25;
                        break;
                    case 100:
                        vasyaMoney -= 75;
                        break;
                }
            }
            return vasyaMoney < 0 ? "NO" : "YES";
        }
    }
}
