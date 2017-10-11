namespace _08.Multiply_big_number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MultiplyBigNumber
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (number == "0" || number == string.Empty || multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            string result = MultiplyNumber(number, multiplier);
            Console.WriteLine(result);
        }

        private static string MultiplyNumber(string number, int multiplier)
        {
            Stack<int> digit = new Stack<int>(number.ToCharArray().Select(n => (int)char.GetNumericValue(n)));
            StringBuilder result = new StringBuilder();
            var sum = 0;
            while (digit.Count != 0)
            {
                sum += digit.Pop() * multiplier;
                result.Insert(0, sum % 10);
                sum /= 10;
            }

            result.Insert(0, sum);

            return result.ToString().TrimStart('0');
        }
    }
}
