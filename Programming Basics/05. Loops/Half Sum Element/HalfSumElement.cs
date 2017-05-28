using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (max < num)
                {
                    max = num;
                }
                sum = sum + num;
            }
            if (max == (sum - max))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + Math.Abs((sum - max)));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(max -(sum - max)));
            }
        }
    }
}
