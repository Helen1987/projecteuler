using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
    /// 
    /// Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
    /// 
    /// (Please note that the palindromic number, in either base, may not include leading zeros.)
    /// </summary>
    public class Task36
    {
        public long Run(int maxNumber)
        {
            long sum = 0;
            for (int i = 1; i < maxNumber; i += 2)
            {
                if (SpecialNumbers.IsPalindrome(i, 10) && SpecialNumbers.IsPalindrome(i, 2))
                {
                    sum += i;
                }
            }
            return sum;
        }

    }
}
