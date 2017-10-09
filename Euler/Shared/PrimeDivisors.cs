using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class PrimeDivisors
    {
        readonly ESieve _sieve;
        List<int> _primes = new List<int>();
        List<int> _counts = new List<int>();

        public PrimeDivisors(int number, ESieve sieve)
        {
            _sieve = sieve;
            FindPrimeDivisors(number);
        }

        public List<int> GetFactors()
        {
            List<int> factors = new List<int>();
            for (int i = 0; i < _primes.Count; ++i)
            {
                factors.Add((int)Math.Pow(_primes[i], _counts[i]));
            }
            return factors;
        }

        private void FindPrimeDivisors(int number)
        {
            foreach (int prime in _sieve.GetPrimes())
            {
                if (prime * prime > number) break;

                if (number % prime != 0) continue;

                _primes.Add(prime);
                int count = 0;
                while (number % prime == 0)
                {
                    count++;
                    number /= prime;
                }
                _counts.Add(count);
            }
            if (number > 1)
            {
                _primes.Add(number);
                _counts.Add(1);
            }
        }

        public int GetGCP(PrimeDivisors others)
        {
            int gcp = 1;
            for (int i = 0; i < _primes.Count(); ++i)
            {
                int otherIndex = others._primes.FindIndex(prime => prime ==_primes[i]);
                if (otherIndex == -1) continue;

                int power = Math.Min(_counts[i], others._counts[otherIndex]);
                gcp *= (int)Math.Pow(_primes[i], power);
            }
            return gcp;
        }
    }
}
