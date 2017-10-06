using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Common
    {
        public static IEnumerable<long> GetPermutations(int[] digits, Dictionary<int, Predicate<long>> restrictions = null)
        {
            if (digits.Length == 1)
            {
                yield return digits[0];
            }

            for (int i = 0; i < digits.Length; ++i)
            {
                var restDigits = digits.ToList();
                restDigits.RemoveAt(i);
                foreach (long perm in GetPermutations(restDigits.ToArray(), restrictions))
                {
                    if (restrictions != null)
                    {
                        if (restrictions.ContainsKey(restDigits.Count))
                        {
                            if (!restrictions[restDigits.Count](perm))
                                continue;
                        }
                    }
                    yield return digits[i] * (long)Math.Pow(10, restDigits.Count) + perm;
                }
            }
        }
    }
}
