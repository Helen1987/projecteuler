using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Task16
    {
        /// <summary>
        /// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

        //// What is the sum of the digits of the number 2^1000?
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public int Run(int power)
        {
            int result = 0;

            String value = BigInteger.Pow(new BigInteger(2), power).ToString();
            foreach (char a in value)
            {
                result = result + int.Parse(a.ToString());
            }
            return result;
        }
    }
}
