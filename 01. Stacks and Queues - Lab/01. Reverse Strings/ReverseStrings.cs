using System;
using System.Collections.Generic;

namespace _01.Reverse_Strings
{
    public class ReverseStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            Console.WriteLine(string.Join("", stack));
        }
    }
}
