using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 
    /// 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.
    /// 
    /// Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
    /// 
    /// NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.
    /// </summary>
    public class Task37
    {
        ESieve _sieve = new ESieve(1000000);
        List<int> searchList = new List<int>() { 3, 7 };

        int[] appends = { 1, 2, 3, 5, 7, 9 };

        public int Run()
        {
            int count = 0;
            int sum = 0;
            while (count < 11)
            {
                int suggestedPrime = searchList[0];
                searchList.RemoveAt(0);
                if (_sieve.IsPrime(suggestedPrime))
                {
                    int order = 1;
                    // check if it is right truncatable prime
                    int primeCopy = suggestedPrime;
                    bool isTrancatablePrime = true;
                    while (primeCopy > 0)
                    {
                        if (!_sieve.IsPrime(primeCopy))
                        {
                            isTrancatablePrime = false;
                        }

                        primeCopy /= 10;
                        order *= 10;
                    }

                    if (isTrancatablePrime && suggestedPrime > 10)
                    {
                        sum += suggestedPrime;
                        count++;
                    }

                    // generate suggested primes by adding from the left
                    for (int i = 0; i < appends.Length; ++i)
                    {
                        searchList.Add(order * appends[i] + suggestedPrime);
                    }
                }
            }
            return sum;
        }
    }
}
