using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
    /// 
    /// We shall consider fractions like, 30/50 = 3/5, to be trivial examples.
    /// 
    /// There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.
    /// 
    /// 
    /// If the product of these four fractions is given in its lowest common terms, find the value of the denominator.
    /// </summary>
    public class Task33
    {
        private bool IsNonTrivialExample(int numerator, int denominator)
        {
            int num1 = numerator / 10;
            int num2 = numerator % 10;
            int den1 = denominator / 10;
            int den2 = denominator % 10;

            if (den1 == 0 && den2 == 0) return false;

            if (num1 == den1 && den2 != 0)
            {
                return numerator / (double)denominator == num2 / (double)den2;
            }
            if (num1 == den2 && den1 != 0)
            {
                return numerator / (double)denominator == num2 / (double)den1;
            }
            if (num2 == den1 && den2 != 0)
            {
                return numerator / (double)denominator == num1 / (double)den2;
            }
            return false;
        }

        private int GetDenominatorOfFractionsProduct()
        {
            int numeratorProduct = 1;
            int denominatorProduct = 1;
            for (int i = 10; i <= 98; ++i)
            {
                for (int j = i + 1; j <= 99; ++j)
                {
                    if (IsNonTrivialExample(i, j))
                    {
                        numeratorProduct *= i;
                        denominatorProduct *= j;
                    }
                }
            }
            if (denominatorProduct % numeratorProduct == 0)
            {
                return denominatorProduct / numeratorProduct;
            }
            ESieve sieve = new ESieve((int)Math.Max(numeratorProduct, denominatorProduct));
            PrimeDivisors numPrimeDivisors = new PrimeDivisors(numeratorProduct, sieve);
            PrimeDivisors denPrimeDivisors = new PrimeDivisors(denominatorProduct, sieve);

            int gcp = numPrimeDivisors.GetGCP(numPrimeDivisors);
            return denominatorProduct / gcp;
        }

        public int Run()
        {
            return GetDenominatorOfFractionsProduct();
        }
    }
}
