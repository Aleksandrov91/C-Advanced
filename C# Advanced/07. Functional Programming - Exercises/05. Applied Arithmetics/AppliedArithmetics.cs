using System;
using System.Linq;

namespace _05.Applied_Arithmetics
{
    public class AppliedArithmetics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        Func<int, int> increaseNum = n => n + 1;
                        ManipulateArr(numbers, increaseNum);
                        break;
                    case "multiply":
                        Func<int, int> multiplyNum = n => n * 2;
                        ManipulateArr(numbers, multiplyNum);
                        break;
                    case "subtract":
                        Func<int, int> substractNum = n => n - 1;
                        ManipulateArr(numbers, substractNum);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }

                command = Console.ReadLine();
            }
        }

        public static void ManipulateArr(int[] numbers, Func<int, int> operation)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = operation(numbers[i]);
            }
        }
    }
}
