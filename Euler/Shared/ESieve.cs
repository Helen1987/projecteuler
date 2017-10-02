using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ESieve
    {
        int[] primes;
        List<int> tempPrimes = new List<int>() { 2 };

        private bool IsProposedPrime(int suggestedPrime)
        {
            foreach (int prime in tempPrimes)
            {
                if (prime > Math.Sqrt(suggestedPrime))
                    return true;
                if (suggestedPrime % prime == 0)
                    return false;
            }
            return true;
        }

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
    }
}
