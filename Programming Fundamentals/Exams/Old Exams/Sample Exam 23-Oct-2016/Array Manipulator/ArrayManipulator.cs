using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var result = new List<string>();
            var command = Console.ReadLine();

            while (command != "end")
            {
                if (command.Contains("exchange"))
                {
                    var split = command.Split();
                    int index = int.Parse(split[1]);
                    if (index < 0 || index > input.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }

                    input = GetExchange(input, index);
                }
                else if (command.Contains("max"))
                {
                    var number = int.MinValue;
                    if (command.Contains("even"))
                    {
                        int key = 0;
                        number = GetMax(input, key, number);
                    }
                    else if (command.Contains("odd"))
                    {
                        int key = 1;
                        number = GetMax(input, key, number);

                    }

                    if (number == int.MinValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine($"{number}");
                    }
                }
                else if (command.Contains("min"))
                {
                    var number = int.MaxValue;
                    if (command.Contains("even"))
                    {
                        int key = 0;
                        number = GetMin(input, key, number);
                    }
                    else if (command.Contains("odd"))
                    {
                        int key = 1;
                        number = GetMin(input, key, number);
                    }

                    if (number == int.MaxValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine($"{number}");
                    }
                }
                else if (command.Contains("first"))
                {
                    var split = command.Split();
                    int count = int.Parse(split[1]);
                    var firstItems = new List<int>();

                    if (count < 0 || count > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    if (command.Contains("even"))
                    {
                        int key = 0;
                        firstItems = GetFirst(input, key, count);
                    }
                    else if (command.Contains("odd"))
                    {
                        int key = 1;
                        firstItems = GetFirst(input, key, count);

                    }

                    var firstItem = firstItems.Take(count).ToList();
                    Console.WriteLine($"[{string.Join(", ", firstItem)}]");
                }
                else if (command.Contains("last"))
                {
                    var split = command.Split();
                    int count = int.Parse(split[1]);
                    var lastItems = new List<int>();

                    if (count < 0 || count > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    if (command.Contains("even"))
                    {
                        int key = 0;
                        lastItems = GetFirst(input, key, count);
                    }
                    else if (command.Contains("odd"))
                    {
                        int key = 1;
                        lastItems = GetFirst(input, key, count);
                    }

                    lastItems.Reverse();
                    var lastItem = lastItems.Take(count).Reverse();
                    Console.WriteLine($"[{string.Join(", ", lastItem)}]");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        public static int[] GetExchange(int[] input, int index)
        {
            var first = input.Take(index + 1);
            var second = input.Skip(index + 1).ToArray();
            var result = second.Concat(first).ToArray();
            return result;
        }

        public static int GetMax(int[] input, int key, int number)
        {
            var temp = int.MinValue;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] % 2 == key)
                {
                    if (input[i] > temp)
                    {
                        temp = input[i];
                        number = i;
                    }
                }
            }

            return number;
        }

        public static int GetMin(int[] input, int key, int number)
        {
            var temp = int.MaxValue;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] % 2 == key)
                {
                    if (input[i] < temp)
                    {
                        temp = input[i];
                        number = i;
                    }
                }
            }

            return number;
        }

        public static List<int> GetFirst(int[] input, int key, int count)
        {
            var result = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == key)
                {
                    result.Add(input[i]);
                }
            }

            return result;
        }
    }
}
