using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, the sum of the proper divisors 
    /// of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
    /// 
    /// A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.
    /// 
    /// As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24.
    /// By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. However, 
    /// this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of 
    /// two abundant numbers is less than this limit.
    /// 
    /// Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
    /// </summary>
    public class Task23
    {
        private const int MAX_ABUNDANT_SUM = 28123;
        private const int MIN_ABUNDANT_NUMBER = 12;
        private const int MIN_ABUNDANT_SUM = 24;
        private List<int> abundantNumbers = new List<int>();
        private bool[] abundantSums = new bool[MAX_ABUNDANT_SUM];

        private bool IsAbundantNumber(int number)
        {
            int sum = 0;
            foreach (int divisor in Divisors.GetDivisors(number))
            {
                sum += divisor;
            }
            return sum > number;
        }

        private void FindAbundantNumbers()
        {
            abundantNumbers.Add(MIN_ABUNDANT_NUMBER);
            for (int i = MIN_ABUNDANT_NUMBER + 1; i < MAX_ABUNDANT_SUM; ++i)
            {
                if (IsAbundantNumber(i))
                {
                    abundantNumbers.Add(i);
                }
            }
        }

        private void FindAbundantSums()
        {
            foreach (int first in abundantNumbers)
            {
                foreach (int second in abundantNumbers)
                {
                    int sum = first + second;
                    if (sum < MAX_ABUNDANT_SUM)
                    {
                        abundantSums[sum] = true;
                    }
                }
            }
        }

        private int FindNonAbundantSum()
        {
            FindAbundantSums();

            int sumOfNonAbundantSums = (MIN_ABUNDANT_SUM - 1) * MIN_ABUNDANT_SUM / 2;
            for (int sum = MIN_ABUNDANT_SUM + 1; sum < abundantSums.Length; ++sum)
            {
                if (!abundantSums[sum])
                {
                    sumOfNonAbundantSums += sum;
                }
            }
            return sumOfNonAbundantSums;
        }

        public int Run()
        {
            FindAbundantNumbers();
            return FindNonAbundantSum();
        }
    }
}
