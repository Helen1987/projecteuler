using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.
    /// 
    /// {20,48,52}, {24,45,51}, {30,40,50}
    /// 
    /// For which value of p ≤ 1000, is the number of solutions maximised?
    /// </summary>
    public class Task39
    {
        public int Run()
        {
            int maximumCount = -1;
            int maximumP = -1;
            for (int p = 2; p <= 1000; ++p)
            {
                int currentCount = 0;
                for (int hypotenuse = p / 3; hypotenuse < p - 1; ++hypotenuse)
                {
                    int sumOfSides = p - hypotenuse;
                    for (int a = 1; a <= sumOfSides / 2; ++a)
                    {
                        int b = sumOfSides - a;

                        if (a * a + b * b == hypotenuse * hypotenuse)
                        {
                            currentCount++;
                        }
                    }
                }
                if (currentCount > maximumCount)
                {
                    maximumCount = currentCount;
                    maximumP = p;
                }
            }
            return maximumP;
        }
    }
}
