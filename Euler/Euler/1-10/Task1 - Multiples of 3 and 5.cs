using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Task1
    {
        private bool IsMultiple(int number)
        {
            return number % 5 == 0 || number % 3 == 0;
        }

        public int Run(int maxNumber)
        {
            int sum = 0;
            for (int i = 1; i < maxNumber; ++i)
            {
                if (IsMultiple(i))
                {
                    sum += i;
                }
            }

            return sum;
        }

    }
}
