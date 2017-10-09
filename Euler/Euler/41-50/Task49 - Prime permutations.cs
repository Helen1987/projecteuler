using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330, is unusual in two ways: (i) each of the three terms are prime, and, (ii) each of the 4-digit numbers are permutations of one another.
    /// 
    /// There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property, but there is one other 4-digit increasing sequence.
    /// 
    /// What 12-digit number do you form by concatenating the three terms in this sequence?
    /// </summary>
    public class Task49
    {
        ESieve sieve = new ESieve(10000);

        const int STEP = 3330;

        private IEnumerable<int> GetDigits(int number)
        {
            while (number > 0)
            {
                yield return number % 10;
                number /= 10;
            }
        }

        public string Run()
        {
            foreach (int prime in sieve.GetPrimes(1487))
            {
                int prime2 = prime + STEP;
                int prime3 = prime + 2*STEP;
                if (sieve.IsPrime(prime2) && sieve.IsPrime(prime3))
                {
                    List<int> digits1 = GetDigits(prime).ToList();
                    digits1.Sort();
                    List<int> digits2 = GetDigits(prime2).ToList();
                    digits2.Sort();
                    List<int> digits3 = GetDigits(prime3).ToList();
                    digits3.Sort();
                    bool isDesiredNumber = true;
                    for (int i = 0; i < digits1.Count; ++i)
                    {
                        if (digits1[i] != digits2[i] || digits2[i] != digits3[i] || digits1[i] != digits3[i])
                        {
                            isDesiredNumber = false;
                            break;
                        }
                    }
                    if (isDesiredNumber)
                    {
                        return prime.ToString() + prime2.ToString() + prime3.ToString();
                    }
                }
            }
            return string.Empty;
        }

    }
}
