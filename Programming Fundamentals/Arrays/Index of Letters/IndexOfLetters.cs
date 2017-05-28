using System;
using System.Linq;

namespace Index_of_Letters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i] - 'a';
                Console.WriteLine($"{arr[i]} -> {number}");
            }

        }
    }
}
