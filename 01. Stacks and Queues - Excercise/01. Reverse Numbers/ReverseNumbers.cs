using System;
using System.Collections.Generic;

namespace _01.Reverse_Numbers
{
    public class ReverseNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(int.Parse(input[i]));
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
