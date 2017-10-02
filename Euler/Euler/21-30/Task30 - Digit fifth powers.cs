using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
    /// 
    /// 1634 = 14 + 64 + 34 + 44
    /// 8208 = 84 + 24 + 04 + 84
    /// 9474 = 94 + 44 + 74 + 44
    /// As 1 = 14 is not a sum it is not included.
    /// 
    /// The sum of these numbers is 1634 + 8208 + 9474 = 19316.
    /// 
    /// Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
    /// </summary>
    public class Task30
    {
        private bool IsSumOfFifthPowers(int number)
        {
            int numberCopy = number;
            int order = 1, digit;
            int sum = 0;
            do
            {
                digit = numberCopy % 10;
                order *= 10;
                numberCopy /= 10;
                sum += (int)Math.Pow(digit, 5);
            } while (numberCopy > 0);

            return sum == number;
        }

        public int Run()
        {
            int sum = 0;
            int max = (int)Math.Pow(9, 5) * 6;
            for (int i = 2; i < max; ++i)
            {
                if (IsSumOfFifthPowers(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
