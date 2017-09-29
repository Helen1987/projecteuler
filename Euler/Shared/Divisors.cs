using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Divisors
    {
        public static IEnumerable<int> GetDivisors(int number)
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
    }
}
