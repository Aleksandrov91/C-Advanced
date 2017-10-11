using System;

namespace Reverse_Strings_Array
{
    public class ReverseStringsArray
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] reversed = new string[input.Length];
            int index = 1;
            for (int i = 0; i < input.Length; i++)
            {
                reversed[i] = input[input.Length - index];
                index ++;
            }
            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
