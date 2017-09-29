using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// n! means n × (n − 1) × ... × 3 × 2 × 1
    /// 
    /// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
    /// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
    /// 
    /// Find the sum of the digits in the number 100!
    /// </summary>
    public class Task20
    {
        private Dictionary<int, BigInteger> memo = new Dictionary<int, BigInteger>();

        private BigInteger GetFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            if (memo.ContainsKey(number))
            {
                return memo[number];
            }
            memo.Add(number, number * GetFactorial(number - 1));
            return memo[number];
        }

        public int Run(int number)
        {
            string factorial = GetFactorial(number).ToString();
            int sum = 0;
            foreach (char i in factorial)
            {
                sum += int.Parse(i.ToString());
            }
            return sum;
        }
    }
}
