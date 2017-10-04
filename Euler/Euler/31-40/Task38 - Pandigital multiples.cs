using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// Take the number 192 and multiply it by each of 1, 2, and 3:
    /// 
    /// 192 × 1 = 192
    /// 192 × 2 = 384
    /// 192 × 3 = 576
    /// By concatenating each product we get the 1 to 9 pandigital, 192384576. We will call 192384576 the concatenated product of 192 and(1,2,3)
    /// 
    /// The same can be achieved by starting with 9 and multiplying by 1, 2, 3, 4, and 5, giving the pandigital, 918273645, which is the concatenated product of 9 and(1,2,3,4,5).
    /// 
    /// What is the largest 1 to 9 pandigital 9-digit number that can be formed as the concatenated product of an integer with(1,2, ... , n) where n > 1?
    /// </summary>
    public class Task38
    {
        private bool IsPandigital(string number)
        {
            bool[] occurrence = new bool[9];
            for (int i = 0; i < number.Length; ++i)
            {
                int digit = int.Parse(number[i].ToString());
                if (digit == 0)
                {
                    return false;
                }
                if (occurrence[digit - 1])
                {
                    return false;
                }
                occurrence[digit - 1] = true;
            }
            return true;
        }

        public string Run()
        {
            int multiplier = 1;
            int number = 1;
            string pandigital = string.Empty;
            string maxPandigital = pandigital;
            while (true)
            {
                pandigital += (multiplier++ * number).ToString();
                if (pandigital.Length == 9)
                {
                    if (IsPandigital(pandigital) && pandigital.CompareTo(maxPandigital) > 0)
                    {
                        maxPandigital = pandigital;
                    }
                }
                else if (pandigital.Length > 9)
                {
                    if (multiplier <= 2 || (multiplier == 3 && pandigital.Length >= 5))
                    {
                        break; // no chance to find more Pandigital multiples
                    }

                    number++;
                    multiplier = 1;
                    pandigital = string.Empty;
                }
            }
            return maxPandigital;
        }
    }
}
