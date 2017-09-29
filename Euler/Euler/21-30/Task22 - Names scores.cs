using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. 
    /// Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
    /// 
    /// For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.So,
    /// COLIN would obtain a score of 938 × 53 = 49714.
    /// 
    /// What is the total of all the name scores in the file?
    /// </summary>
    public class Task22
    {
        private SortedList<string, int> sortedNames = new SortedList<string, int>();
        private const char DELIMITER = ',';
        private const char QUOTE = '"';

        private int GetCharPosition(int characterValue) => characterValue - 'A' + 1;

        private void ReadNames()
        {
            string name = string.Empty;
            int sum = 0;
            using (StreamReader reader = new StreamReader("data/p022_names.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int nextCharacter = reader.Read();
                    if (nextCharacter == QUOTE)
                    {
                        if (!string.IsNullOrEmpty(name))
                        {
                            sortedNames.Add(name, sum);
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
        }

        private long GetSum()
        {
            long score = 0;
            for (int i = 0; i < sortedNames.Count(); ++i)
            {
                score += (i + 1) * sortedNames.ElementAt(i).Value;
            }
            return score;
        }

        public long Run()
        {
            ReadNames();
            return GetSum();
        }
    }
}
