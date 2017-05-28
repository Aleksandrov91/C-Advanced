using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var previousSum = 0;
            var diffSum = 0;
            for (int i = 0; i < n; i++)
            {
                previousSum = sum;
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                sum = a + b;
                diffSum = Math.Abs(sum - previousSum);
            }
            if (n > 1)
            {
                if (previousSum == sum)
                {
                    Console.WriteLine("Yes, value = " + sum);
                    

                }
                else
                {
                    Console.WriteLine("No, maxdiff = " + diffSum);
                }
            }
            else
            {
                Console.WriteLine("Yes, value = " + sum);
            }
        }
    }
}
