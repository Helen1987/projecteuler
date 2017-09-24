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
            var task = new Task3();
            long max = 600851475143;
            Console.WriteLine($"Largest prime factor of {max} is {task.Run(max)}");
        }
    }
}
