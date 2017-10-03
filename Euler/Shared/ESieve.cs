using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ESieve : BaseSieve
    {
        int[] primes;

        public ESieve(int number)
        {
            for (int suggestedPrime = 3; suggestedPrime < number; suggestedPrime += 2)
            {
                if (IsProposedPrime(suggestedPrime))
                {
                    tempPrimes.Add(suggestedPrime);
                }
            }
            primes = tempPrimes.ToArray();
        }

        public bool IsPrime(int number)
        {
            return Array.BinarySearch(primes, number) > -1;
        }

        public long Aggregate(Func<long, long, long> func)
        {
            long total = 0;
            foreach (int prime in primes)
            {
                total = func(total, prime);
            }
            return total;
        }

        public IEnumerable<int> GetPrimes()
        {
            return primes;
        }
    }
}
