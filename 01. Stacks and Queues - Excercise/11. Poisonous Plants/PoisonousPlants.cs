using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Poisonous_Plants
{
    public class PoisonousPlants
    {
        public static void Main()
        {
            var numberOfPlants = int.Parse(Console.ReadLine());
            var argsArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var livePlants = new Stack<int>();
            var tempPlants = new Stack<int>();

            for (int i = 0; i < argsArray.Length; i++)
            {
                livePlants.Push(argsArray[i]);
            }

            var days = 0;
            var currentCount = livePlants.Count;

            while (true)
            {
                currentCount = livePlants.Count;

                for (int i = 0; i < livePlants.Count;  i++)
                {
                    var currentPlant = livePlants.Pop();
                    var neighborPlant = livePlants.Pop();

                    if (currentPlant > neighborPlant)
                    {
                        tempPlants.Push(currentPlant);
                    }
                    else
                    {
                        tempPlants.Push(neighborPlant);
                        tempPlants.Push(currentPlant);
                    }
                }

                livePlants = tempPlants;
                days++;
                
                if (currentCount == livePlants.Count)
                {
                    Console.WriteLine(days);
                    return;
                }
            }
        }
    }
}
