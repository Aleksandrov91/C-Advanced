using System;
using System.Collections.Generic;

namespace Primes_in_Given_Range
{
    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            var primesInRange = FindPrimesInRange(firstNumber, secondNumber);
            Console.WriteLine(string.Join(", ", primesInRange));

        }
        public static bool IsPrime(long number)
        {
            bool isPrime = true;
            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            else
            {
                for (long i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            return isPrime;
        }
        static List<int> FindPrimesInRange(int firstNumber, int secondNumber)
        {
            var primes = new List<int>();
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
    }
}
