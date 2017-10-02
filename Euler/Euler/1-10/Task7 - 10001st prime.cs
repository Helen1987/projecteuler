using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Task7 : BaseSieve
    {
        public int Run(int number)
        {
            int count = 1;
            int suggestedPrime = 3;

            while (count < number)
            {
                if (IsProposedPrime(suggestedPrime))
                {
                    tempPrimes.Add(suggestedPrime);
                    count++;
                }
                suggestedPrime++;
            }
            return tempPrimes[tempPrimes.Count - 1];
        }
    }
}
