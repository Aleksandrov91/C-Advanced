using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Truck_Tour
{
    public class TruckTour
    {
        public static void Main()
        {
            var numberOfPumps = int.Parse(Console.ReadLine());
            var truckStops = new Queue<string>();
            var fuelTank = 0;
            bool result = false;
            var count = 0;

            for (int i = 0; i < numberOfPumps; i++)
            {
                var args = Console.ReadLine();
                truckStops.Enqueue(args);
            }

            for (int i = 0; i < numberOfPumps; i++)
            {
                for (int j = 0; j < numberOfPumps; j++)
                {
                    var reminder = truckStops.Peek()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    var dequeue = truckStops.Dequeue();
                    truckStops.Enqueue(dequeue);

                    fuelTank += reminder[0];
                    var distanceToNextPump = reminder[1];

                    if (fuelTank < distanceToNextPump)
                    {
                        fuelTank = 0;
                        result = false;
                        count++;
                        break;
                    }
                    else
                    {
                        fuelTank -= distanceToNextPump;
                        result = true;
                    }

                    count++;
                }

                if (result)
                {
                    Console.WriteLine(count - numberOfPumps);
                    return;
                }
            }
        }
    }
}
