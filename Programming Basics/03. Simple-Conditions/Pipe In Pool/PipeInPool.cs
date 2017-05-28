using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipe_In_Pool
{
    class PipeInPool
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double p1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double capacity = (p1 + p2) * n;

            if (capacity <= V )
            {
                //capacity /= 10;
                p1 = (p1 * n / capacity) * 100;
                p2 = (p2 * n / capacity) * 100;
                capacity = capacity / V * 100;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Floor(capacity), Math.Floor(p1), Math.Floor(p2));
            }
            else
            {
                var liters = ((p1 + p2) * n) - V;
                Console.WriteLine("For " + n + " hours the pool overflows with " + liters + " liters.");
            }
        }
    }
}
