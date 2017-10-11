using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Basic_Stack_Operations
{
    public class BasicStackOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();

            var pushNumbers = input[0];
            var popNumbers = input[1];
            var numberToCheck = input[2];

            var numbersToPush = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(numbersToPush);

            for (int i = 0; i < popNumbers; i++)
            {
                stack.Pop();
            }

            var smallestNumber = int.MaxValue;

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (stack.Count != 0)
            {
                var reminder = stack.Pop();
                if (numberToCheck == reminder)
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    if (reminder < smallestNumber)
                    {
                        smallestNumber = reminder;
                    }   
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
