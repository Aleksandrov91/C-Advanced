using System;

namespace Fibonacci_Numbers
{
    public class FibonacciNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            GetFibonacciNumber(number);
            Console.WriteLine(GetFibonacciNumber(number));
        }

        public static int GetFibonacciNumber(int number)
        {
            int firstNumber = 0;
            int result = 1;
            for (int i = 0; i < number; i++)
            {
                int temp = firstNumber;
                firstNumber = result;
                result = temp + firstNumber;
            }

            return result;
        }
    }
}
