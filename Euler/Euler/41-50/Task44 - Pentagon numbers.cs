﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// Pentagonal numbers are generated by the formula, Pn=n(3n−1)/2. The first ten pentagonal numbers are:
    /// 
    /// 1, 5, 12, 22, 35, 51, 70, 92, 117, 145, ...
    /// 
    /// It can be seen that P4 + P7 = 22 + 70 = 92 = P8.However, their difference, 70 − 22 = 48, is not pentagonal.
    /// 
    /// Find the pair of pentagonal numbers, Pj and Pk, for which their sum and difference are pentagonal and D = | Pk − Pj| is minimised; what is the value of D?
    /// </summary>
    public class Task44
    {
        private List<int> pentagonals = new List<int>();
        private int lastN = 1;

        private int GeneratePentagonal(int n) => n * (3 * n - 1) / 2;

        private bool IsPentagonial(int number)
        {
            while (!pentagonals.Any() || pentagonals.Last() < number)
            {
                pentagonals.Add(GeneratePentagonal(lastN++));
            }
            return pentagonals.Contains(number);
        }

        private int GetPentagonial(int index)
        {
            while (!pentagonals.Any() || lastN <= index)
            {
                pentagonals.Add(GeneratePentagonal(lastN++));
            }
            return pentagonals[index-1];
        }

        public int Run()
        {
            int minD = int.MaxValue;
            int currentN = 1;
            while (true)
            {
                int p1 = GetPentagonial(currentN++);
                for (int i = currentN - 1; i > 0; --i)
                {
                    if (IsPentagonial(p1 - pentagonals[i-1]) && IsPentagonial(p1 + pentagonals[i-1]))
                    {
                        int diff = Math.Abs(p1 - pentagonals[i-1]);
                        if (diff < minD)
                        {
                            return diff;
                        }
                    }
                }
            }
        }
    }
}
