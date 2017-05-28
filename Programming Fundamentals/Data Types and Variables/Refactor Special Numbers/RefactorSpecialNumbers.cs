using System;

namespace Refactor_Special_Numbers
{
    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int currentNumber = 0;
            bool isSpecial = false;
            for (int num = 1; num <= n; num++)
            {
                currentNumber = num;
                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;
                }

                isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{currentNumber} -> {isSpecial}");
                sumOfDigits = 0;
                num = currentNumber;
            }
        }
    }
}
