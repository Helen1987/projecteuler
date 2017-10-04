using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class SpecialNumbers
    {
        private static int GetMaxPower(int number)
        {
            int i;
            for (i = 1; i <= 10; ++i)
            {
                if (number / (int)Math.Pow(10, i) == 0)
                {
                    break;
                }
            }
            return i;
        }

        private static int GetDigit(int number, int step)
        {
            int rest = number % (int)Math.Pow(10, step);
            return rest / (int)Math.Pow(10, step - 1);
        }

        public static bool IsPalindromNumber(int number)
        {
            int highPower = GetMaxPower(number);
            int lowPower = 1;

            while (highPower >= lowPower)
            {
                int highDigit = GetDigit(number, highPower--);
                int lowDigit = GetDigit(number, lowPower++);
                if (highDigit != lowDigit)
                    return false;
            }
            return true;
        }

        public static bool IsPalindrome(int number, int b = 10)
        {
            string numberInBase = Convert.ToString(number, b);
            char[] arr = numberInBase.ToCharArray();
            Array.Reverse(arr);
            return numberInBase.Equals(new string(arr));
        }
    }
}
