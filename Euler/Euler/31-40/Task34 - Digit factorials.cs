using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
    /// 
    /// Find the sum of all numbers which are equal to the sum of the factorial of their digits.
    /// 
    /// Note: as 1! = 1 and 2! = 2 are not sums they are not included.
    /// </summary>
    public class Task34
    {
        int MAX = 1000000;
        int[] FACTORIALS = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };

        private int GetFuctorialsSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += FACTORIALS[number % 10];
                number /= 10;
            }
            return sum;
        }

        public int Run()
        {
            int factorialSum = 0;
            for (int i = 10; i < MAX; ++i)
            {
                if (i == GetFuctorialsSum(i))
                {
                    factorialSum += i;
                }
            }
            return factorialSum;
        }
    }
}
