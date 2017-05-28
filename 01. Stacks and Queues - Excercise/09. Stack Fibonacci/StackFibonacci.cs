using System;
using System.Collections.Generic;

namespace _09.Stack_Fibonacci
{
    public class StackFibonacci
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var stack = new Stack<long>();

            stack.Push(0);
            stack.Push(1);

            for (int i = 2; i <= n; i++)
            {
                long a = stack.Pop();
                long b = stack.Pop();

                stack.Push(a);
                stack.Push(a + b);
            }

            Console.WriteLine(stack.Peek());
        }
    }
}
