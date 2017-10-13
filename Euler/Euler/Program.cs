using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Task59();
            int keyLength = 3;
            Console.WriteLine($"The sum of the ASCII values in the original text is { task.Run(keyLength) }");
        }
    }
}
