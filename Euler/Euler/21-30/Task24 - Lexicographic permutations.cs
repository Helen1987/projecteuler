using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:
    /// 
    /// 012   021   102   120   201   210
    /// 
    /// What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
    /// </summary>
    public class Task24
    {
        private readonly int _availableDigits;
        private readonly List<int> _digits;

        public Task24(int availableDigits)
        {
            _availableDigits = availableDigits;
            _digits = Enumerable.Range(0, availableDigits).ToList();
        }

        private int GetFactorial(int number) => number <= 1 ? 1 : Enumerable.Range(1, number).Aggregate((p, x) => p * x);

        private int FindDigit(int digitPosition, ref int permutationsCount)
        {
            int permutationsPerNumber = GetFactorial(digitPosition - 1);
            int digitIndex = permutationsCount / permutationsPerNumber;
            permutationsCount %= permutationsPerNumber;

            int digit = _digits[digitIndex];
            _digits.RemoveAt(digitIndex);

            return digit;
        }

        public long Run(int permutaitionNumber)
        {
            permutaitionNumber -= 1; // we need zero-based index
            int order = (int)Math.Pow(10, _availableDigits - 1);
            long permutation = 0;
            for (int i = _availableDigits; i >= 1; --i)
            {
                int permutationDigit = FindDigit(i, ref permutaitionNumber);
                permutation += permutationDigit * order;
                order /= 10;
            }
            return permutation;
        }
    }
}
