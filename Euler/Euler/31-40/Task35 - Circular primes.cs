using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
    /// 
    /// There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
    /// 
    /// How many circular primes are there below one million?
    /// </summary>
    public class Task35
    {
        SortedSet<int> _circularPrimes = new SortedSet<int>();
        SortedSet<int> _checkedPrimes = new SortedSet<int>();
        readonly ESieve sieve;

        public Task35(int maxValue)
        {
            sieve = new ESieve(maxValue);
        }

        private IEnumerable<int> GetDigits(int number)
        {
            while (number > 0)
            {
                yield return number % 10;
                number /= 10;
            }
        }

        /*public void CheckPermutationPrime(int prime)
        {
            int[] digits = GetDigits(prime).ToArray();
            List<int> perm = new List<int>();
            foreach (int permutation in GetPermutations(digits))
            {
                if (!sieve.IsPrime(permutation)) return;

                _checkedPrimes.Add(permutation);
                perm.Add(permutation);
            }
            perm.ForEach(circularPrime => _circularPrimes.Add(circularPrime));
        }*/
        
        public void CheckCircularPrime(int prime)
        {
            int length = prime.ToString().Length;
            List<int> shifts = new List<int>();
            int count = 1;
            _checkedPrimes.Add(prime);
            shifts.Add(prime);

            while (count++ < length)
            {
                prime = prime / 10 + (prime % 10) * (int) Math.Pow(10, length - 1);
                if (!sieve.IsPrime(prime)) return;

                _checkedPrimes.Add(prime);
                shifts.Add(prime);
            }
            shifts.ForEach(circularPrime => _circularPrimes.Add(circularPrime));
        }

        public int Run()
        {
            foreach (int prime in sieve.GetPrimes())
            {
                if (_checkedPrimes.Contains(prime)) continue;
                CheckCircularPrime(prime);
            }
            return _circularPrimes.Count();
        }
    }
}
