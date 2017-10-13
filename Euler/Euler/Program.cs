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
            var task = new Task54();
            Console.WriteLine($"How many hands does Player 1 win is { task.Run() }");
        }
    }
}
