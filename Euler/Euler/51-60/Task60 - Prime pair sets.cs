using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The primes 3, 7, 109, and 673, are quite remarkable. By taking any two primes and concatenating them in any order the result will always be prime.
    /// For example, taking 7 and 109, both 7109 and 1097 are prime. The sum of these four primes, 792, represents the lowest sum for a set of four primes with this property.

    /// Find the lowest sum for a set of five primes for which any two primes concatenate to produce another prime.
    /// </summary>
    public class Task60
    {
        ESieve eSieve = new ESieve(30000);

        public bool MakePrimes(int prime1, int prime2)
        {
            string concat1 = prime1.ToString() + prime2.ToString(),
                concat2 = prime2.ToString() + prime1.ToString();
            long newPrime1 = long.Parse(concat1);
            long newPrime2 = long.Parse(concat2);
            return MillerRabin.IsPrime(newPrime1) && MillerRabin.IsPrime(newPrime2);
        }

        public int Run()
        {
            int minSum = int.MaxValue;
            foreach (int firstPrime in eSieve.GetPrimes())
            {
                if (firstPrime * 5 > minSum) break;
  
                foreach (int secondPrime in eSieve.GetPrimes(firstPrime))
                {
                    if (firstPrime + secondPrime * 4 > minSum) break;

                    if (!MakePrimes(firstPrime, secondPrime))
                    {
                        continue;
                    }

                    foreach (int thirdPrime in eSieve.GetPrimes(secondPrime))
                    {
                        if (firstPrime + secondPrime + thirdPrime * 3 > minSum) break;

                        if (!MakePrimes(thirdPrime, secondPrime) || !MakePrimes(thirdPrime, firstPrime))
                        {
                            continue;
                        }

                        foreach (int fourthPrime in eSieve.GetPrimes(thirdPrime))
                        {
                            if (firstPrime + secondPrime + thirdPrime + fourthPrime * 2 > minSum) break;

                            if (!MakePrimes(fourthPrime, thirdPrime) || !MakePrimes(fourthPrime, secondPrime) || !MakePrimes(fourthPrime, firstPrime))
                            {
                                continue;
                            }

                            foreach (int fifthPrime in eSieve.GetPrimes(fourthPrime))
                            {
                                if (firstPrime + secondPrime + thirdPrime + fourthPrime + fifthPrime > minSum) break;

                                if (!MakePrimes(fifthPrime, fourthPrime) || !MakePrimes(fifthPrime, thirdPrime) 
                                    || !MakePrimes(fifthPrime, secondPrime) || !MakePrimes(fifthPrime, firstPrime))
                                {
                                    continue;
                                }
                                int sum = firstPrime + secondPrime + thirdPrime + fourthPrime + fifthPrime;
                                if (minSum > sum)
                                {
                                    minSum = sum;
                                }
                            }
                        }
                    }
                }
            }
            return minSum;
        }
    }
}
