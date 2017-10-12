using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// It is possible to show that the square root of two can be expressed as an infinite continued fraction.

    /// √ 2 = 1 + 1/(2 + 1/(2 + 1/(2 + ... ))) = 1.414213...
    /// 
    /// By expanding this for the first four iterations, we get:
    /// 
    /// 1 + 1/2 = 3/2 = 1.5
    /// 1 + 1/(2 + 1/2) = 7/5 = 1.4
    /// 1 + 1/(2 + 1/(2 + 1/2)) = 17/12 = 1.41666...
    /// 1 + 1/(2 + 1/(2 + 1/(2 + 1/2))) = 41/29 = 1.41379...
    /// 
    /// The next three expansions are 99/70, 239/169, and 577/408, but the eighth expansion, 1393/985, is the first example where 
    /// the number of digits in the numerator exceeds the number of digits in the denominator.
    /// 
    /// In the first one-thousand expansions, how many fractions contain a numerator with more digits than denominator?
    /// </summary>
    public class Task57
    {
        /*
         * pattern: 
         *      n(k+1) = n(k)+2*d(k)
         *      d(k+1) = n(k)+d(k)
         * could be written as follows:
         *      n(k+1) = n(k)+2*d(k)
         *      d(k+1) = n(k+1) - d(k)
         */
        public int Run(int expansionsCount)
        {
            BigInteger nk = 3;
            BigInteger dk = 2;
            int count = 0;
            for (int i = 1; i < expansionsCount; ++i)
            {
                if ((int)BigInteger.Log10(nk) > (int)BigInteger.Log10(dk))
                {
                    count++;
                }
                nk += 2 * dk;
                dk = nk - dk;
            }
            return count;
        }

    }
}
