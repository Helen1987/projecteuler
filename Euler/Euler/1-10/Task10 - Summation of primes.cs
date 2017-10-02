using Shared;
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
        public long Run(int maxValue)
        {
            ESieve sieve = new ESieve(maxValue);
            return sieve.Aggregate((total, prime) => total + prime);
        }
    }
}
