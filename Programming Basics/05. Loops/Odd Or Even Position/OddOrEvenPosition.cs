using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Or_Even_Position
{
    class OddOrEvenPosition
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0d;
            var oddMaxSum = double.MinValue;
            var evenMaxSum = double.MinValue;
            var oddMinSum = double.MaxValue;
            var evenMinSum = double.MaxValue;
            var oddSum = 0d;
            var evenSum = 0d;
            for (int i = 0; i < n; i++)
            {
                var element = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += element;
                    if (oddMaxSum < element)
                    {
                        oddMaxSum = element;
                    }
                    if (oddMinSum > element)
                    {
                        oddMinSum = element;
                    }
                }
                else
                {
                    evenSum += element;
                    if (evenMaxSum < element)
                    {
                        evenMaxSum = element;
                    }
                    if (evenMinSum > element)
                    {
                        evenMinSum = element;
                    }
                }
            }
            if (n > 1)
            {
                Console.WriteLine("OddSum = " + oddSum);
                Console.WriteLine("OddMin = " + oddMinSum);
                Console.WriteLine("OddMax = " + oddMaxSum);
                Console.WriteLine("EvenSum = " + evenSum);
                Console.WriteLine("EvenMin = " + evenMinSum);
                Console.WriteLine("EvenMax = " + evenMaxSum);
            }
            else if (n == 0)
            {
                Console.WriteLine("OddSum = " + oddSum);
                Console.WriteLine("OddMin = No");
                Console.WriteLine("OddMax = No");
                Console.WriteLine("EvenSum = " + evenSum);
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("OddSum = " + oddSum);
                Console.WriteLine("OddMin = " + oddMinSum);
                Console.WriteLine("OddMax = " + oddMaxSum);
                Console.WriteLine("EvenSum = " + evenSum);
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
        }
    }
}
