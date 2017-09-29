using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
    ///
    /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
    /// 
    /// 
    /// NOTE: Do not count spaces or hyphens.For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) 
    /// contains 20 letters.The use of "and" when writing out numbers is in compliance with British usage.
    /// </summary>
    public class Task17
    {
        private Dictionary<int, int> mapNumberToLength = new Dictionary<int, int>()
        {
            { 1, 3 }, // "one"
            { 2, 3 }, // "two"
            { 3, 5 }, // "three"
            { 4, 4 }, // "four",
            { 5, 4 }, // "five"
            { 6, 3 }, // "six"
            { 7, 5 }, // "seven"
            { 8, 5 }, // "eight",
            { 9, 4 }, // "nine",
            { 10, 3 }, // "ten",
            { 11, 6 }, // "eleven",
            { 12, 6 }, // "twelve",
            { 13, 8 }, // "thirteen",
            { 14, 8 }, // "fourteen",
            { 15, 7 }, // "fifteen",
            { 16, 7 }, // "sixteen",
            { 17, 9 }, // "seventeen",
            { 18, 8 }, // "eighteen",
            { 19, 8 }, // "nineteen"
            { 20, 6 }, // "twenty"
            { 30, 6 }, // "thirty"
            { 40, 5 }, // "forty"
            { 50, 5 }, // "fifty"
            { 60, 5 }, // "sixty"
            { 70, 7 }, // "seventy"
            { 80, 6 }, // "eighty"
            { 90, 6 }, // "ninety"
            { 100, 7 }, // "hundred"
            { 1000, 8 } // "thousand"
        };

        private int GetNumberLength(int order, int rest)
        {
            if (rest > 0)
            {
                return (order <= 10) ? mapNumberToLength[rest * order] : mapNumberToLength[rest] + mapNumberToLength[order];
            }
            return 0;
        }

        private int GetWordsLength(int number)
        {
            int copyNumber = number;
            int order = 1;
            int count = 0;

            int lastTwo = number % 100;
            if (lastTwo > 0 && lastTwo < 21)
            {
                count = mapNumberToLength[lastTwo];
                copyNumber /= 100;
                order *= 100;
            }

            while (copyNumber > 0)
            {
                if (order == 100 && count > 0 && copyNumber > 0) // add length of "and"
                {
                    count += 3;
                }
                int rest = copyNumber % 10;
                count += GetNumberLength(order, rest);
                order *= 10;
                copyNumber /= 10;
            }
            return count;
        }

        public int Run(int maxNumber)
        {
            int length = 0;
            for (int i = 1; i <= maxNumber; ++i)
            {
                length += GetWordsLength(i);
            }
            return length;
        }

    }
}
