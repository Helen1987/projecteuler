using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// A googol (10^100) is a massive number: one followed by one-hundred zeros; 100^100 is almost unimaginably large: one followed by two-hundred zeros.
    /// Despite their size, the sum of the digits in each number is only 1.
    /// 
    /// Considering natural numbers of the form, a^b, where a, b < 100, what is the maximum digital sum?
    /// </summary>
    public class Task56
    {
        private int SumOfDigits(BigInteger number)
        {
            char[] numberAsChars = number.ToString().ToCharArray();
            int sum = 0;
            for (int i = 0; i < numberAsChars.Length; ++i)
            {
                sum += int.Parse(numberAsChars[i].ToString());
            }
            return sum;
        }

        public int Run(int maxNumber)
        {
            int maxSum = 0;

            for (int a = maxNumber - 1; a > 0; --a)
            {
                for (int b = maxNumber - 1; b > 0; --b)
                {
                    BigInteger number = BigInteger.Pow(a, b);
                    if (((int)BigInteger.Log10(number)) * 9 < maxSum)
                    {
                        break;
                    }
                    int sum = SumOfDigits(number);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }
    }
}
