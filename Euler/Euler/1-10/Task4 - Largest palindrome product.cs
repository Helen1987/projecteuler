using Shared;
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
                        if (SpecialNumbers.IsPalindrome(suggestedPalindrom))
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
    }
}
