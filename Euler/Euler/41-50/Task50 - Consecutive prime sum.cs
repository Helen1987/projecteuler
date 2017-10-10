using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The prime 41, can be written as the sum of six consecutive primes:
    /// 
    /// 41 = 2 + 3 + 5 + 7 + 11 + 13
    /// This is the longest sum of consecutive primes that adds to a prime below one-hundred.
    /// 
    /// The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.
    /// 
    /// Which prime, below one-million, can be written as the sum of the most consecutive primes?
    /// </summary>
    public class Task50
    {
        private IEnumerable<long> CalculateSums(int[] primes)
        {
            long sum = 0;
            foreach (int prime in primes)
            {
                sum += prime;
                yield return sum;
            }
        }

        public int Run(int maxNumber)
        {
            ESieve eSieve = new ESieve(maxNumber);
            int[] primes = eSieve.GetPrimes().ToArray();
            long[] primeSum = CalculateSums(primes).ToArray();

            int maxLength = -1;
            int desiredPrime = -1;
            int i = 0;
            while (i < primeSum.Length)
            {
                for (int j = i - (maxLength + 1); j >= 0; --j)
                {
                    if (primeSum[i] - primeSum[j] > maxNumber)
                    {
                        break;
                    }

                    int sugestedPrime = (int)(primeSum[i] - primeSum[j]);
                    if (Array.BinarySearch(primes, sugestedPrime) > -1)
                    {
                        maxLength = i - j;
                        desiredPrime = sugestedPrime;
                    }
                }
                i++;
            }
            return desiredPrime;
        }
    }
}
