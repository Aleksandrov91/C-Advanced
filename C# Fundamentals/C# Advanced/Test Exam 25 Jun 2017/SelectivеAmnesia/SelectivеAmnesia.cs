using System;
using System.Collections.Generic;

namespace SelectivеAmnesia
{
    public class SelectivеAmnesia
    {
        public static int larrysPoints = 0;
        public static int robbinsPoints = 0;
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var larrysMemory = new HashSet<int>();
            var robinsMemory = new Queue<int>();
            var calledNums = new List<int>();

            while (inputLine != "END")
            {
                var data = int.Parse(inputLine);
                LarryStrategy(larrysMemory, data, calledNums);
                RobbinStrategy(robinsMemory, data);

                inputLine = Console.ReadLine();
            }

            if (larrysPoints == robbinsPoints)
            {
                Console.WriteLine($"Draw {robbinsPoints}");
            }
            else
            {
                Console.WriteLine(larrysPoints > robbinsPoints ? $"Larry {larrysPoints} Wins" : $"Robbin {robbinsPoints} Wins");
            }
        }

        private static void LarryStrategy(HashSet<int> larrysMemory, int data, List<int> calledNums)
        {
            calledNums.Add(data);
            if (!larrysMemory.Contains(data) && larrysMemory.Count < 5)
            {
                larrysMemory.Add(data);
            }
            else if (larrysMemory.Contains(data))
            {
                calledNums.Remove(data);
                larrysPoints++;
            }
            else
            {
                larrysMemory.Remove(calledNums[0]);
                calledNums.RemoveAt(0);
                larrysMemory.Add(data);
            }
        }

        private static void RobbinStrategy(Queue<int> robbinsMemory, int data)
        {
            if (!robbinsMemory.Contains(data) && robbinsMemory.Count < 5)
            {
                robbinsMemory.Enqueue(data);
            }
            else if (robbinsMemory.Contains(data))
            {
                robbinsPoints++;
            }
            else
            {
                robbinsMemory.Dequeue();
                robbinsMemory.Enqueue(data);
            }
        }
    }
}
