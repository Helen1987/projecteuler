using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million
    /// </summary>
    public class Task10
    {
        List<int> primes = new List<int>() { 2 };

        public long Run(int maxValue)
        {
            for (int i = 3; i < maxValue; ++i)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return GetPrimeProduct();
        }

        private long GetPrimeProduct()
        {
            long product = 0;
            foreach (int prime in primes)
            {
                product += prime;
            }
            return product;
        }

        private bool IsPrime(int suggestedPrime)
        {
            foreach (int prime in primes)
            {
                if (prime > Math.Sqrt(suggestedPrime))
                    return true;
                if (suggestedPrime % prime == 0)
                    return false;
            }
            return true;
        }
    }
}
