using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317.

    /// Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.
    /// </summary>
    public class Task48
    {
        const long MODULO = 10000000000;

        public long Run(int maxNumber)
        {
            long sum = 0;
            for (int i = 1; i <= maxNumber; ++i)
            {
                long powerOfNumber = 1;
                for (int power = 1; power <= i; ++power)
                {
                    powerOfNumber *= i;
                    powerOfNumber %= MODULO;
                }
                sum += powerOfNumber;
                sum %= MODULO;
            }
            return sum;
        }
    }
}
