using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The following iterative sequence is defined for the set of positive integers:
    /// n → n/2 (n is even)
    /// n → 3n + 1 (n is odd)
    /// 
    /// Using the rule above and starting with 13, we generate the following sequence:
    /// 
    /// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    /// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
    /// Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
    /// 
    /// Which starting number, under one million, produces the longest chain?
    /// 
    /// NOTE: Once the chain starts the terms are allowed to go above one million.
    /// </summary>
    public class Task14
    {
        // number to count of terms
        private Dictionary<long, int> memo = new Dictionary<long, int>();

        private long GetNextNumber(long number) => (number % 2 == 0) ? number / 2 : checked ( 3 * number + 1 );

        private int GetTermsCount(long number, int count = 1)
        {
            if (number == 1)
            {
                return count;
            }
            if (memo.ContainsKey(number))
            {
                return memo[number];
            }
            int finalCount = GetTermsCount(GetNextNumber(number), count + 1) + 1;
            memo.Add(number, finalCount);
            return finalCount;
        }

        public int Run(int largestNumber)
        {
            int largestChainCount = -1, largestChainNumber = 1;
            for (int i = 2; i < largestNumber; ++i)
            {
                int count = GetTermsCount(i);

                if (count > largestChainCount)
                {
                    largestChainCount = count;
                    largestChainNumber = i;
                }
            }
            return largestChainNumber;
        }
    }
}
