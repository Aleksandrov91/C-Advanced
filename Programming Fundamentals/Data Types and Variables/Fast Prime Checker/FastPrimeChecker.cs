using System;

namespace Fast_Prime_Checker
{
    public class FastPrimeChecker
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= number; currentNumber++)
            {
                bool isPrime = true;
                for (int divider = 2; divider <= Math.Sqrt(currentNumber); divider++)
                {
                    if (currentNumber % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }
        }
    }
}
