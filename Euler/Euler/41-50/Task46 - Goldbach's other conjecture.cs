using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.
    /// 
    /// 9 = 7 + 2×12
    /// 15 = 7 + 2×22
    /// 21 = 3 + 2×32
    /// 25 = 7 + 2×32
    /// 27 = 19 + 2×22
    /// 33 = 31 + 2×12
    /// 
    /// It turns out that the conjecture was false.
    /// 
    /// What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?
    /// </summary>
    public class Task46 : BaseSieve
    {
        public int Run()
        {
            int prime = 3;
            while (true)
            {
                if (IsProposedPrime(prime))
                {
                    tempPrimes.Add(prime);
                }
                else if (prime % 2 == 1)
                {
                    bool isCompositePrime = false;
                    for (int i = 1; i < Math.Sqrt(prime / 2); ++i)
                    {
                        if (IsProposedPrime(prime - 2 * i * i))
                        {
                            isCompositePrime = true;
                            break;
                        }
                    }
                    if (!isCompositePrime)
                    {
                        return prime;
                    }
                }
                prime++;
            }
        }
    }
}
