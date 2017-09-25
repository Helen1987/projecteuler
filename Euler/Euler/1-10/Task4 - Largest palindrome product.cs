using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Task4
    {
        public int Run(int count)
        {
            int initValue = GetMaxNumber(count);
            int largestPalindrom = 1;
            for (int firstNumber = initValue; firstNumber > 0; --firstNumber)
            {
                bool hasLargeValue = false;

                for (int secondNumber = initValue; secondNumber > 0; --secondNumber)
                {
                    int suggestedPalindrom = secondNumber * firstNumber;
                    if (suggestedPalindrom > largestPalindrom)
                    {
                        hasLargeValue = true;
                        if (IsPalindrom(suggestedPalindrom))
                        {
                            largestPalindrom = suggestedPalindrom;
                        }
                    }
                }

                if (!hasLargeValue)
                    break;
            }
            return largestPalindrom;
        }

        private int GetMaxNumber(int count) => int.Parse(new string('9', count));

        private int GetMaxPower(int number)
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

        private int GetDigit(int number, int step)
        {
            int rest = number % (int)Math.Pow(10, step);
            return rest / (int)Math.Pow(10, step - 1);
        }

        private bool IsPalindrom(int number)
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
    }
}
