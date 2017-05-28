using System;
using System.Numerics;

namespace Factorial_Zeroes
{
    public class FactorialZeroes
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            CalculateFactorial(num);
        }

        public static void CalculateFactorial(int num)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }

            TrailingZeroes(sum);
        }

        public static void TrailingZeroes(BigInteger sum)
        {
            int count = 0;
            BigInteger lastDigit = 0;
            BigInteger previousNum = 0;
            for (BigInteger i = sum; i >= 0; i--)
            {
                lastDigit = (sum % 10);
                previousNum = ((sum % 100) / 10);
                if (lastDigit == 0 && previousNum == 0)
                {
                    count++;
                }
                else if (lastDigit == 0 && previousNum != 0)
                {
                    count++;
                    break;
                }
                else if (lastDigit != 0)
                {
                    break;
                }
                sum = sum / 10;
            }
            Console.WriteLine(count);
        }
    }
}
