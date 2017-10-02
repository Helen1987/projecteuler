using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The Fibonacci sequence is defined by the recurrence relation:
    /// 
    /// Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
    /// Hence the first 12 terms will be:
    /// 
    /// F1 = 1
    /// F2 = 1
    /// F3 = 2
    /// F4 = 3
    /// F5 = 5
    /// F6 = 8
    /// F7 = 13
    /// F8 = 21
    /// F9 = 34
    /// F10 = 55
    /// F11 = 89
    /// F12 = 144
    /// The 12th term, F12, is the first term to contain three digits.
    /// 
    /// What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
    /// </summary>
    public class Task25
    {
        private Dictionary<int, string> memo = new Dictionary<int, string>();

        private string Add(string n1, string n2)
        {
            string result = string.Empty;
            int length1 = n1.Length - 1;
            int length2 = n2.Length - 1;

            int prev = 0, digit1, digit2, sum, nextDigit;
            while (length1 >= 0 || length2 >=0)
            {
                digit1 = (length1 >=0) ? int.Parse(n1[length1--].ToString()) : 0;
                digit2 = (length2 >= 0) ? int.Parse(n2[length2--].ToString()) : 0;
                sum = digit1 + digit2 + prev;
                prev = sum / 10;
                nextDigit = sum % 10;
                result = nextDigit.ToString() + result;
            }
            if (prev > 0)
            {
                result = prev.ToString() + result;
            }
            return result;
        }

        private string Fibbonacci(int index)
        {
            if (index == 1 || index == 2) return "1";

            if (memo.ContainsKey(index)) return memo[index];

            string prev = Fibbonacci(index - 1);
            string prevprev = Fibbonacci(index - 2);
            memo.Add(index, Add(prev, prevprev));
            return memo[index];
        }

        public int Run(int digitsNumber)
        {
            int i = 10;
            while (true)
            {
                string nextFibonacci = Fibbonacci(i++);
                if (nextFibonacci.Length == digitsNumber)
                {
                    return i - 1;
                }
            }
        }
    }
}
