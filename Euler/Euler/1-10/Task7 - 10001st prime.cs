using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Task7
    {
        List<int> primes = new List<int>() { 2 };

        public int Run(int number)
        {
            int count = 1;
            int suggestedPrime = 3;

            while (count < number)
            {
                if (IsPrime(suggestedPrime))
                {
                    primes.Add(suggestedPrime);
                    count++;
                }
                suggestedPrime++;
            }
            return primes[primes.Count - 1];
        }

        private bool IsPrime(int suggestedPrime)
        {
            foreach (int prime in primes)
            {
                if (suggestedPrime % prime == 0)
                    return false;
            }
            return true;
        }
    }
}
