using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.

    /// Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits.
    /// </summary>
    public class Task52
    {
        private IEnumerable<int> GetDigits(int number)
        {
            while (number > 0)
            {
                yield return number % 10;
                number /= 10;
            }
        }

        private bool AreDigitsTheSame(int[] digits1, int[] digits2)
        {
            if (digits1.Length != digits2.Length)
            {
                return false;
            }
            for (int i = 0; i < digits1.Length; ++i)
            {
                if (digits1[i] != digits2[i])
                {
                    return false;
                }
            }
            return true;
        }

        private bool HasTheSameDigits(int[] digits1, int number2)
        {
            int[] digits2 = GetDigits(number2).ToArray();
            Array.Sort(digits2);

            return AreDigitsTheSame(digits1, digits2);
        }

        public int Run()
        {
            int number = 10;
            while (true)
            {
                number++;

                int[] digits1 = GetDigits(number).ToArray();
                Array.Sort(digits1);

                if (!HasTheSameDigits(digits1, 2*number)) continue;

                if (!HasTheSameDigits(digits1, 3 * number)) continue;

                if (!HasTheSameDigits(digits1, 4 * number)) continue;

                if (!HasTheSameDigits(digits1, 5 * number)) continue;

                if (!HasTheSameDigits(digits1, 6 * number)) continue;

                return number;
            }
        }
    }
}
