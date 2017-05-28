using System;
using System.Numerics;

namespace Factorial
{
    public class Factorial
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(num));
        }

        public static BigInteger CalculateFactorial(int num)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }

            return sum;
        }
    }
}
