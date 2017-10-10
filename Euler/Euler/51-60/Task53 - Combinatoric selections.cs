using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// There are exactly ten ways of selecting three from five, 12345:
    /// 
    /// 123, 124, 125, 134, 135, 145, 234, 235, 245, and 345
    /// 
    /// In combinatorics, we use the notation, 5C3 = 10.
    /// 
    /// In general,
    /// 
    /// nCr = n!/r!(n−r)!, where r ≤ n, n! = n×(n−1)×...×3×2×1, and 0! = 1.
    /// It is not until n = 23, that a value exceeds one-million: 23C10 = 1144066.
    /// 
    /// How many, not necessarily distinct, values of nCr, for 1 ≤ n ≤ 100, are greater than one-million?
    /// </summary>
    public class Task53
    {
        const int LIMIT = 1000000;

        public int Run(int maxNumber)
        {
            int count = 0;
            for (int n = 1; n <= maxNumber; ++n)
            {
                double product = 1;
                for (int r = n - 1; r >= 0; --r)
                {
                    product *= (r + 1)/(double)(n - r);
                    if (product > LIMIT)
                    {
                        count += 2*r - n + 1;
                        break;
                    }
                }
            }
            return count;
        }
    }
}
