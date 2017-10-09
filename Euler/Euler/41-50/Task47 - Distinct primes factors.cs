using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The first two consecutive numbers to have two distinct prime factors are:
    /// 
    /// 14 = 2 × 7
    /// 15 = 3 × 5
    /// 
    /// The first three consecutive numbers to have three distinct prime factors are:
    /// 
    /// 644 = 2² × 7 × 23
    /// 645 = 3 × 5 × 43
    /// 646 = 2 × 17 × 19.
    /// 
    /// Find the first four consecutive integers to have four distinct prime factors each.What is the first of these numbers?
    /// </summary>
    public class Task47
    {
        ESieve sieve = new ESieve(10000);
        const int FACTORS_COUNT = 4;

        private bool AreDistinct(List<int> list1, List<int> list2)
        {
            return list1.Intersect(list2).Count() == 0;
        }

        public int Run()
        {
            int number = 378;
            while (true)
            {
                PrimeDivisors div1 = new PrimeDivisors(number, sieve);
                List<int> factors1 = div1.GetFactors();
                if (factors1.Count == FACTORS_COUNT)
                {
                    PrimeDivisors div2 = new PrimeDivisors(number + 1, sieve);
                    List<int> factors2 = div2.GetFactors();
                    if (factors2.Count == FACTORS_COUNT)
                    {
                        if (!AreDistinct(factors1, factors2))
                        {
                            number++;
                        }
                        else {
                            PrimeDivisors div3 = new PrimeDivisors(number + 2, sieve);
                            List<int> factors3 = div3.GetFactors();
                            if (factors3.Count == FACTORS_COUNT)
                            {
                                if (!AreDistinct(factors2, factors3))
                                {
                                    number += 2;
                                }
                                else if (!AreDistinct(factors1, factors3))
                                {
                                    number++;
                                }
                                else
                                {
                                    PrimeDivisors div4 = new PrimeDivisors(number + 3, sieve);
                                    List<int> factors4 = div4.GetFactors();
                                    if (factors4.Count == FACTORS_COUNT)
                                    {
                                        if (!AreDistinct(factors3, factors4))
                                        {
                                            number += 3;
                                        }
                                        else if (!AreDistinct(factors2, factors4))
                                        {
                                            number += 2;
                                        }
                                        else if (!AreDistinct(factors1, factors4))
                                        {
                                            number++;
                                        }
                                        return number;
                                    }
                                    else
                                    {
                                        number += 4;
                                    }
                                }
                            }
                            else
                            {
                                number += 3;
                            }
                        }
                    }
                    else
                    {
                        number += 2;
                    }
                }
                else {
                    number++;
                }
            }
        }
    }
}
