using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var indexes = new List<int>();
            while (true)
            {
                string[] line = Console.ReadLine().Split(' ');
                string command = line[0];
                indexes.Clear();
                for (int i = 1; i < line.Length; i++)
                {
                    indexes.Add(int.Parse(line[i]));
                }

                if (command == "print")
                {
                    Console.WriteLine($"[{string.Join(", ", nums)}]");

                    break;
                }
                else if (command == "add")
                {
                    Add(nums, indexes);
                }
                else if (command == "addMany")
                {
                    AddMany(nums, indexes);
                }
                else if (command == "contains")
                {
                    Console.WriteLine(Contains(nums, indexes));
                }
                else if (command == "remove")
                {
                    Remove(nums, indexes);
                }
                else if (command == "shift")
                {
                    Shift(nums, indexes);
                }
                else if (command == "sumPairs")
                {
                    SumPairs(nums);
                }
            }
        }

        public static List<int> Add(List<int> nums, List<int> indexes)
        {
            nums.Insert(indexes[0], indexes[1]);
            return nums;
        }

        public static List<int> AddMany(List<int> nums, List<int> indexes)
        {
            int position = indexes[0];
            indexes.RemoveAt(0);
            nums.InsertRange(position, indexes);
            return nums;
        }

        public static int Contains(List<int> nums, List<int> indexes)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == indexes[0])
                {
                    return i;
                }
            }

            return -1;
        }

        public static List<int> Remove(List<int> nums, List<int> indexes)
        {
            nums.RemoveAt(indexes[0]);
            return nums;
        }

        public static List<int> Shift(List<int> nums, List<int> indexes)
        {
            int range = indexes[0];
            for (int i = 0; i < range; i++)
            {
                int firstNum = nums[0];
                for (int j = 1; j < nums.Count; j++)
                {
                    nums[j - 1] = nums[j];
                }

                nums[nums.Count - 1] = firstNum;
            }

            return nums;
        }

        public static List<int> SumPairs(List<int> nums)
        {
            var sum = new List<int>();

            for (int i = 1; i < nums.Count; i += 2)
            {
                sum.Add(nums[i] + nums[i - 1]);
            }

            if (nums.Count % 2 != 0)
            {
                sum.Add(nums[nums.Count - 1]);
            }

            nums.Clear();
            nums.AddRange(sum);
            return nums;
        }
    }
}