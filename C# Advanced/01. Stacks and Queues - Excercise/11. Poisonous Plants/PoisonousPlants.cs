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

            var plants = new Queue<int>();
            var days = 1;

            for (int i = 0; i < numberOfPlants; i++)
            {
                plants.Enqueue(argsArray[i]);
            }

            while (true)
            {
                var plantsCount = plants.Count;

                if (plantsCount < 2)
                {
                    Console.WriteLine(days - 1);
                    break;
                }

                var plantMustDie = false;

                for (int i = 0; i < plantsCount; i++)
                {
                    var currentPlant = plants.Dequeue();
                    var neighborPlant = plants.Peek();

                    if (plantMustDie)
                    {
                        plantMustDie = false;
                    }
                    else
                    {
                        plants.Enqueue(currentPlant);
                    }

                    if (currentPlant < neighborPlant)
                    {
                        plantMustDie = true;
                    }
                }

                if (plantsCount == plants.Count)
                {
                    Console.WriteLine(days - 1);
                    return;
                }

                days++;
            }
            
        }
    }
}
