using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
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
