using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Task3
    {
        long largestPrime = 1;

        public long Run(long number)
        {
            long copyNumber = number;
            for (long i = 2; i <= copyNumber; ++i)
            {
                if (number % i == 0)
                {
                    largestPrime = i;
                    while (copyNumber % i == 0)
                    {
                        copyNumber /= i;
                    }
                }
            }

            return largestPrime;
        }
    }
}
