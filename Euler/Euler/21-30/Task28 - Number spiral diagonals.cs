using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Task28
    {
        public long Run(int rows)
        {
            long sum = 1;
            for (int i = 3; i <= rows; i += 2)
            {
                sum += 4 * i * i - 6*(i - 1);
            }
            return sum;
        }
    }
}
