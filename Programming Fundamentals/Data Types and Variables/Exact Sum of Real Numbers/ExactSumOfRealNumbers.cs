using System;

namespace Exact_Sum_of_Real_Numbers
{
    public class ExactSumOfRealNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sumNumber = 0;
            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sumNumber += number;
            }

            Console.WriteLine(sumNumber);
        }
    }
}
