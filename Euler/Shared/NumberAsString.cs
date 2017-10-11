using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public static class NumberAsString
    {
        private static int GetSumOfDigits(int digitNumber, int previousValue, string[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += int.Parse(number[digitNumber].ToString());
            }
            return sum + previousValue;
        }

        public static string Sum(string[] numbers)
        {
            int previousSum = 0, currentSum = 0;
            string result = string.Empty;
            for (int i = numbers[0].Length - 1; i >= 0; --i)
            {
                currentSum = GetSumOfDigits(i, previousSum, numbers);
                result = (currentSum % 10).ToString() + result;
                previousSum = currentSum / 10;
            }
            if (previousSum > 0)
            {
                result = previousSum.ToString() + result;
            }

            return result;
        }
    }
}
