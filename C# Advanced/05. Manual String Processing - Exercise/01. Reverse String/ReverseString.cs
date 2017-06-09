using System;
using System.Linq;
using System.Text;

namespace _01.Reverse_String
{
    public class ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var reversed = Reverse(input);
            Console.WriteLine(reversed);
        }

        private static string Reverse(string input)
        {
            var sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }
}
