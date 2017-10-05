using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.
    /// 
    /// What is the largest n-digit pandigital prime that exists?
    /// </summary>
    public class Task41
    {
        private bool IsPrime(long prime)
        {
            long divisor = 3;
            while (divisor * divisor <= prime)
            {
                if (prime % divisor++ == 0)
                    return false;
            }
            return true;
        }

        public long Run()
        {
            int n = 9;
            long maxNumber = -1;
            while (n > 0)
            {
                int[] digits = Enumerable.Range(1, n).ToArray();
                foreach (long candidate in Common.GetPermutations(digits))
                {
                    if (candidate % 2 == 0 || candidate % 5 == 0 || candidate % 3 == 0) continue;

                    if (candidate > maxNumber && IsPrime(candidate))
                    {
                        maxNumber = candidate;
                    }
                }

                if (maxNumber != -1)
                {
                    return maxNumber;
                }
                else
                {
                    n--;
                }
            }
            return maxNumber;
        }
    }
}
