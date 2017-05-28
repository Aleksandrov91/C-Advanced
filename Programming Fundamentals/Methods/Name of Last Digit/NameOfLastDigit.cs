using System;

namespace Name_of_Last_Digit
{
    public class NameOfLastDigit
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            GetLastDigit(number);
            long lastDigit = GetLastDigit(number);
            Console.WriteLine(GetDigitName(lastDigit));
        }

        public static long GetLastDigit(long number)
        {
            long lastDigit = Math.Abs(number % 10);
            GetDigitName(lastDigit);
            return lastDigit;
        }

        public static string GetDigitName(long lastDigit)
        {
            string[] lastDigitName = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //Console.WriteLine(lastDigitName[lastdigit]);
            return lastDigitName[lastDigit];
        }
    }
}
