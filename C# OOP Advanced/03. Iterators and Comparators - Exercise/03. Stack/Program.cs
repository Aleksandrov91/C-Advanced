namespace _03.Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var stack = new Stack<string>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var inputArgs = input.Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = inputArgs[0];
                inputArgs.RemoveAt(0);

                try
                {
                    switch (command)
                    {
                        case "Push":
                            AddElement(inputArgs, stack);
                            break;
                        case "Pop":
                            stack.Pop();
                            break;
                    }
                }
                catch (NullReferenceException nullReferenceException)
                {
                    Console.WriteLine(nullReferenceException.Message);
                }
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }

        private static void AddElement(List<string> elementsToAdd, Stack<string> stack)
        {
            foreach (var element in elementsToAdd)
            {
                stack.Push(element);
            }
        }
    }
}
