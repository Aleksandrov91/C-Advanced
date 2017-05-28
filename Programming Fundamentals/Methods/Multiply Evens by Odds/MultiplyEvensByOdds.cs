using System;

namespace Multiply_Evens_by_Odds
{
    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            GetMultipleOfEvensAndOdds(number);
            GetSumOfEvenDigits(number);
            GetSumOfOddDigits(number);
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }

        public static int GetSumOfOddDigits(int number)
        {
            return GetDigit(number, 1);
        }

        public static int GetSumOfEvenDigits(int number)
        {
            return GetDigit(number, 0);
        }

        public static int GetMultipleOfEvensAndOdds(int number)
        {
            return Math.Abs(GetSumOfOddDigits(number) * GetSumOfEvenDigits(number));
        }

        public static int GetDigit(int number, int index)
        {
            var result = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == index)
                {
                    result += digit;
                }
            }

            return result;
        }
    }
}
