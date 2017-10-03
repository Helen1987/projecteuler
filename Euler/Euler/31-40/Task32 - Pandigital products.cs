using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.
    /// 
    /// The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.
    /// 
    /// Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
    /// 
    /// HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.
    /// </summary>
    public class Task32
    {
        int[] _availabelDigits = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> firstNumbers = new List<int>();
        List<int> secondNumbers = new List<int>();
        SortedSet<int> _products = new SortedSet<int>();

        private int GenerateNumber(params int[] indexes)
        {
            int order = 1;
            int number = 0;
            foreach (int index in indexes)
            {
                number += order * _availabelDigits[index];
                order *= 10;
            }
            return number;
        }

        private void GeneratePossibleNumbers()
        {
            for (int i = 0; i < _availabelDigits.Length; ++i)
            {
                firstNumbers.Add(_availabelDigits[i]);
                for (int j = 0; j < _availabelDigits.Length; ++j)
                {
                    if (i != j)
                    {
                        firstNumbers.Add(GenerateNumber(i, j));
                    }
                }
            }
            for (int i = 0; i < _availabelDigits.Length; ++i)
            {
                for (int j = 0; j < _availabelDigits.Length; ++j)
                {
                    for (int k = 0; k < _availabelDigits.Length; ++k)
                    {
                        if (i != j && j != k && i != k)
                        {
                            secondNumbers.Add(GenerateNumber(i, j, k));
                        }
                        for (int n = 0; n < _availabelDigits.Length; ++n)
                        {
                            if (i != j && j != k && i != k && i != n && n != j && n != k)
                            {
                                secondNumbers.Add(GenerateNumber(i, j, k, n));
                            }
                        }
                    }
                }
            }
        }

        private bool IsPandigitalProduct(int n1, int n2)
        {
            bool[] digits = new bool[9];
            int product = n1 * n2;
            string result = n1.ToString() + n2.ToString() + product.ToString();

            if (result.Length != 9) return false;

            for (int i = 0; i < result.Length; ++i)
            {
                int value = int.Parse(result[i].ToString());
                if (value == 0 || digits[value - 1] == true) return false;

                digits[value - 1] = true;
            }
            return digits.Aggregate((a, b) => a && b);
        }

        private int GetSumOfPandigitalProducts()
        {
            for (int i = 0; i < firstNumbers.Count(); ++i)
            {
                for (int j = 0; j < secondNumbers.Count(); ++j)
                {
                    if (IsPandigitalProduct(firstNumbers[i], secondNumbers[j]))
                    {
                        _products.Add(firstNumbers[i] * secondNumbers[j]);
                    }
                }
            }
            return _products.Aggregate((a, b) => a + b);
        }

        public int Run()
        {
            GeneratePossibleNumbers();
            return GetSumOfPandigitalProducts();
        }
    }
}
