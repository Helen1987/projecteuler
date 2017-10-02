using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:
    /// 
    /// 1/2	= 	0.5
    /// 1/3	= 	0.(3)
    /// 1/4	= 	0.25
    /// 1/5	= 	0.2
    /// 1/6	= 	0.1(6)
    /// 1/7	= 	0.(142857)
    /// 1/8	= 	0.125
    /// 1/9	= 	0.(1)
    /// 1/10	= 	0.1
    /// Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle.It can be seen that 1/7 has a 6-digit recurring cycle.
    /// 
    /// Find the value of d< 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
    /// </summary>
    public class Task26
    {
        // since the numerator is 1, when we face the same reminder again, we found the cycle
        private int GetCycleLength(int fraction)
        {
            int[] reminders = new int[fraction];
            int value = 1;
            int position = 0;

            while (reminders[value] == 0 && value != 0)
            {
                reminders[value] = position++;
                value *= 10;
                value = value % fraction;
            }
            return position - reminders[value];
        }

        public int Run(int maxD)
        {
            int longestCycle = 0;
            int longestCycleFraction = 2;
            for (int i = 2; i < maxD; ++i)
            {
                int length = GetCycleLength(i);
                if (length > longestCycle)
                {
                    longestCycle = length;
                    longestCycleFraction = i;
                }
            }
            return longestCycleFraction;
        }
    }
}
