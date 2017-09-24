using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Task2
    {
        int first = 1;
        int second = 2;
        int temp;
        long sum;

        private int getNextFibonnachi(int prev, int current)
        {
            return prev + current;
        }

        public long Run(long maxValue)
        {
            sum = second;
            while (true)
            {
                temp = getNextFibonnachi(first, second);
                if (temp > maxValue)
                    return sum;

                if (temp % 2 == 0)
                {
                    sum += temp;
                }
                first = second;
                second = temp;
            }
        }
    }
}
