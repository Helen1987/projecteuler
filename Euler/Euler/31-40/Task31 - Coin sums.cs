using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:
    /// 
    /// 1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
    /// It is possible to make £2 in the following way:
    /// 
    /// 1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
    /// How many different ways can £2 be made using any number of coins?
    /// </summary>
    public class Task31
    {
        Dictionary<string, int> _memo = new Dictionary<string, int>();
        int[] _availableCoins = new int[] { 1, 2, 5, 10, 20, 50, 100, 200};

        private string GetKey(int money, int[] coins)
        {
            return money.ToString() + "-" + string.Join("", coins);
        }

        private int GetCount(int rest, int[] coins)
        {
            if (rest < 0) return 0;

            if (rest == 0) return 1;

            string key = GetKey(rest, coins);
            if (_memo.ContainsKey(key))
            {
                return _memo[key];
            }
            int count = 0;
            int coin = coins[coins.Length - 1];
            int[] newCoins = coins.Take(coins.Length - 1).ToArray();
            if (newCoins.Length > 0)
            {
                count += GetCount(rest, newCoins);
                while (rest > 0)
                {
                    count += GetCount(rest - coin, newCoins);
                    rest -= coin;
                }
            }
            else if (rest % coin == 0) {
                count = 1;
            }
            _memo.Add(key, count);
            return count;
        }

        public int Run(int money)
        {
            return GetCount(money, _availableCoins);
        }
    }
}
