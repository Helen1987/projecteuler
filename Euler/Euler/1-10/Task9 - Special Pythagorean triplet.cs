using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    /// a2 + b2 = c2
    /// For example, 32 + 42 = 9 + 16 = 25 = 52.
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    public class Task9
    {
        int SUM = 1000;

        public int Run()
        {
            for (int a = 1; a <= SUM - 2; ++a)
            {
                for (int b = a + 1; b <= SUM - 1; ++b)
                {
                    if (IsPythagoreanTriplet(a, b, SUM - a - b))
                    {
                        return a * b * (SUM - a - b);
                    }
                }
            }
            return -1;
        }

        private bool IsPythagoreanTriplet(int a, int b, int c) => a * a + b * b == c * c;
    }
}
