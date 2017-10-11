using System;
using System.Linq;

namespace Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            var field = long.Parse(Console.ReadLine());
            var arr = new long[field];
            var ladybug = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (int i = 0; i < ladybug.Length; i++)
            {
                var currentIndex = ladybug[i];
                if (currentIndex < arr.Length && currentIndex >= 0)
                {
                    arr[currentIndex] = 1;
                }
            }

            var operations = Console.ReadLine();

            while (operations != "end")
            {
                var line = operations.Split().ToArray();
                var index = long.Parse(line[0]);
                var direction = line[1].ToLower();
                var jumps = long.Parse(line[2]);
                if (direction == "right")
                {
                        arr = GetMovedToRight(arr, index, jumps);
                }
                else if (direction == "left")
                {
                        arr = GetMovedToLeft(arr, index, jumps);
                }

                operations = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", arr));
        }

        public static long[] GetMovedToRight(long[] arr, long index, long jumps)
        {
            if (index < arr.Length && index >= 0)
            {
                if (arr[index] == 1)
                {
                    while (true)
                    {
                        arr[index] = 0;
                        if (index + jumps >= arr.Length || index + jumps < 0)
                        {
                            return arr;
                        }
                        else if (arr[index + jumps] == 0)
                        {
                            arr[index + jumps] = 1;
                            return arr;
                        }
                        else
                        {
                            jumps += jumps;
                        }
                    }
                }
            }

            return arr;
        }

        public static long[] GetMovedToLeft(long[] arr, long index, long jumps)
        {
            if (index < arr.Length && index >= 0)
            {
                if (arr[index] == 1)
                {
                    while (true)
                    {
                        arr[index] = 0;
                        if (index - jumps < 0 || index - jumps >= arr.Length)
                        {
                            return arr;
                        }
                        else if (arr[index - jumps] == 0)
                        {
                            arr[index - jumps] = 1;
                            return arr;
                        }
                        else
                        {
                            jumps += jumps;
                        }
                    }
                }
            }

            return arr;
        }
    }
}
