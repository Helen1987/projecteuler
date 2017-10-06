using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The nth term of the sequence of triangle numbers is given by, tn = ½n(n+1); so the first ten triangle numbers are:
    /// 
    /// 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
    /// 
    /// By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value.For example, the word value for SKY is 19 + 11 + 25 = 55 = t10.If the word value is a triangle number then we shall call the word a triangle word.
    /// 
    /// Using words.txt (right click and 'Save Link/Target As...'), a 16K text file containing nearly two-thousand common English words, how many are triangle words?
    /// </summary>
    public class Task42
    {
        private List<int> triangleNumbers = new List<int>();
        private int lastN = 1;
        private const char DELIMITER = ',';
        private const char QUOTE = '"';

        private int GetCharPosition(int characterValue) => characterValue - 'A' + 1;

        private bool IsTriangleSum(int finalSum)
        {
            while (!triangleNumbers.Any() || finalSum > triangleNumbers.Last())
            {
                triangleNumbers.Add(lastN * (lastN + 1) / 2);
                lastN++;
            }
            return triangleNumbers.Contains(finalSum);
        }

        public int Run()
        {
            string name = string.Empty;
            int sum = 0;
            int count = 0;
            using (StreamReader reader = new StreamReader("data/p042_words.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int nextCharacter = reader.Read();
                    if (nextCharacter == QUOTE)
                    {
                        if (!string.IsNullOrEmpty(name))
                        {
                            if (IsTriangleSum(sum))
                            {
                                count++;
                            }
                            name = string.Empty;
                            sum = 0;
                        }
                    }
                    else if (nextCharacter != DELIMITER)
                    {
                        name += (char)nextCharacter;
                        sum += GetCharPosition(nextCharacter);
                    }
                }
            }
            return count;
        }
    }
}
