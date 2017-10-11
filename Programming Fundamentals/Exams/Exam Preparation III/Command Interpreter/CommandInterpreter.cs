using System;
using System.Collections.Generic;
using System.Linq;

namespace Command_Interpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine();
            while (command != "end")
            {
                var line = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (line[0])
                {
                    case "reverse":
                        var reverseStart = int.Parse(line[2]);
                        var reverseCount = int.Parse(line[4]);
                        if (!IsValid(input, reverseStart, reverseCount))
                        {
                            command = Console.ReadLine();
                            continue;
                        }

                        Reverse(input, reverseStart, reverseCount);
                        break;
                    case "sort":
                        var sortStart = int.Parse(line[2]);
                        var sortCount = int.Parse(line[4]);
                        if (!IsValid(input, sortStart, sortCount))
                        {
                            command = Console.ReadLine();
                            continue;
                        }

                        SortArr(input, sortStart, sortCount);
                        break;
                    case "rollLeft":
                        var rollLeftCount = int.Parse(line[1]);
                        if (rollLeftCount < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            command = Console.ReadLine();
                            continue;
                        }

                        RollLeft(input, rollLeftCount);
                        break;
                    case "rollRight":
                        var rollRightCount = int.Parse(line[1]);
                        if (rollRightCount < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            command = Console.ReadLine();
                            continue;
                        }

                        RollRight(input, rollRightCount);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        public static bool IsValid(List<string> input, int start, int count)
        {
            if (start >= 0 && start < input.Count && count >= 0 && start + count <= input.Count)
            {
                return true;
            }

            Console.WriteLine("Invalid input parameters.");
            return false;
        }

        public static void RollRight(List<string> input, int rollRightCount)
        {
            rollRightCount = rollRightCount % input.Count;

            for (int i = 0; i < rollRightCount; i++)
            {
                var temp = input[input.Count - 1];
                for (int j = input.Count - 1; j > 0; j--)
                {
                    input[j] = input[j - 1];
                }

                input[0] = temp;
            }
        }

        public static void RollLeft(List<string> input, int rollLeftCount)
        {
            rollLeftCount = rollLeftCount % input.Count;

            for (int i = 0; i < rollLeftCount; i++)
            {
                var temp = input[0];
                for (int j = 0; j < input.Count - 1; j++)
                {
                    input[j] = input[j + 1];
                }

                input[input.Count - 1] = temp;
            }
        }

        public static void SortArr(List<string> input, int sortStart, int sortCount)
        {
            var sorted = input.Skip(sortStart).Take(sortCount).OrderBy(a => a).ToList();
            input.RemoveRange(sortStart, sortCount);
            input.InsertRange(sortStart, sorted);
        }

        public static void Reverse(List<string> input, int reverseStart, int reverseCount)
        {
            var reversed = input.Skip(reverseStart).Take(reverseCount).Reverse().ToList();
            input.RemoveRange(reverseStart, reverseCount);
            input.InsertRange(reverseStart, reversed);
        }
    }
}
