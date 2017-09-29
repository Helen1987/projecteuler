using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
    /// If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
    /// 
    /// For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. 
    /// The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
    /// 
    /// Evaluate the sum of all the amicable numbers under 10000.
    /// </summary>
    public class Task21
    {
        private Dictionary<int, int> memo = new Dictionary<int, int>();
        private List<int> amicable = new List<int>();

        private IEnumerable<int> GetDivisors(int number)
        {
            yield return 1;

            for (int i = 2; i <= number / 2; ++i)
            {
                if (number % i == 0)
                {
                    yield return i;
                }
            }
        }

        private int GetDofN(int number)
        {
            if (memo.ContainsKey(number))
            {
                return memo[number];
            }
            int sum = 0;
            foreach (int divisor in GetDivisors(number))
            {
                sum += divisor;
            }
            memo.Add(number, sum);
            return sum;
        }

        public int Run(int maxNumber)
        {
            int sum = 0;
            for (int i = 0; i < maxNumber; ++i)
            {
                if (amicable.Contains(i))
                {
                    continue;
                }
                int proposedAmicableNumber = GetDofN(i);
                if (proposedAmicableNumber != i && !amicable.Contains(proposedAmicableNumber) && i == GetDofN(proposedAmicableNumber))
                {
                    sum += i + proposedAmicableNumber;
                    amicable.Add(i);
                    amicable.Add(proposedAmicableNumber);
                }
            }
            return sum;
        }
    }
}
