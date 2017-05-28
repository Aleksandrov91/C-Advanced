using System;

namespace Reversed_Numbers
{
    public class ReversedNumbers
    {
        public static void Main()
        {
            double input = double.Parse(Console.ReadLine());
            GetReversedNumber(input);
            Console.WriteLine(GetReversedNumber(input));
        }

        public static string GetReversedNumber(double input)
        {
            string numString = input.ToString();
            char[] character = numString.ToCharArray();
            Array.Reverse(character);
            return string.Join("", character);
        }
    }
}
