using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// An irrational decimal fraction is created by concatenating the positive integers:
    /// 
    /// 0.123456789101112131415161718192021...
    /// 
    /// It can be seen that the 12th digit of the fractional part is 1.
    /// 
    /// If dn represents the nth digit of the fractional part, find the value of the following expression.
    /// 
    /// d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000
    /// </summary>
    public class Task40
    {
        int[] FACTORIALS = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
        int[] REQUIRED_NUMBERS = { 1, 10, 100, 1000, 10000, 100000, 1000000 };

        private int GetPossibleNumbersCount(int digitsCount) => 9*(int)Math.Pow(10, digitsCount - 1);

        public int Run()
        {
            int index = 1;
            int position = 0;
            int product = 1;
            int numberLength = 1;
            while (index < REQUIRED_NUMBERS.Length)
            {
                int lookupIndex = REQUIRED_NUMBERS[index++];
                while (position + GetPossibleNumbersCount(numberLength) * numberLength < lookupIndex)
                {
                    position += GetPossibleNumbersCount(numberLength)*numberLength++;
                }
                int diff = lookupIndex - position;
                int numberNumber = diff/ numberLength;
                int digitNumber = diff % numberLength;

                int lookupDigit = -1; //((int)Math.Pow(10, numberLength - 1) + numberNumber - 1)) % (int)Math.Pow(10, digitNumber + 1) / (int)Math.Pow(10, digitNumber);
                Console.WriteLine(lookupDigit);
                product *= lookupDigit;
            }
            return product;
        }
    }
}
