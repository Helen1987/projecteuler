using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 12 + 22 + ... + 102 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)2 = 552 = 3025
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    public class Task6
    {
        private long GetSquaredSum(int number) => number * (number + 1) * (2 * number + 1) / 6;

        private long GetSum(int number) => number * (number + 1) / 2;

        public long Run(int number)
        {
            long sum = GetSum(number);
            return sum*sum - GetSquaredSum(number);
        }
    }
}
