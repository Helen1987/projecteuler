using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class BaseSieve
    {
        protected List<int> tempPrimes = new List<int>() { 2 };

        protected bool IsProposedPrime(int suggestedPrime)
        {
            foreach (int prime in tempPrimes)
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
