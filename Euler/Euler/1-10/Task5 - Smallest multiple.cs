using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class Task5
    {
        List<int> primes = new List<int>();
        List<int> counts = new List<int>();

        public int Run(int upToNumber)
        {
            int smallestMultiple = 1;
            for (int i = 2; i <= upToNumber; ++i)
            {
                ExtractPrimes(i);
            }
            for (int i = 0; i < primes.Count; ++i)
            {
                smallestMultiple *= (int)Math.Pow(primes[i], counts[i]);
            }
            return smallestMultiple;
        }

        private void ExtractPrimes(int number)
        {
            int tempCopy = number;
            for (int i = 0; i <primes.Count; ++i)
            {
                int prime = primes[i];
                int counter = 0;
                while (tempCopy % prime == 0)
                {
                    tempCopy /= prime;
                    counter++;
                }
                if (counts[i] < counter)
                {
                    counts[i] = counter;
                }
            }

            if (tempCopy > 1)
            {
                primes.Add(tempCopy);
                counts.Add(1);
            }
        }
    }
}
