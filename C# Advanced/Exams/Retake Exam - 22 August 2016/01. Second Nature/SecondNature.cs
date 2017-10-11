namespace _01.Second_Nature
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SecondNature
    {
        public static void Main()
        {
            var flowersInput = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse);

            var buckets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var flowers = new Queue<int>(flowersInput);
            var watterSup = new Stack<int>(buckets);
            var secondNature = new List<int>();
            var water = 0;
            var currentFlower = 0;

            while (flowers.Count > 0 && watterSup.Count > 0)
            {
                currentFlower = flowers.Dequeue();
                water = watterSup.Pop();

                if (currentFlower == water)
                {
                    secondNature.Add(currentFlower);
                }
                else if (water > currentFlower)
                {
                    water -= currentFlower;

                    if (watterSup.Count > 0)
                    {
                        watterSup.Push(watterSup.Pop() + water);
                    }
                    else
                    {
                        watterSup.Push(water);
                    }
                }
                else if (currentFlower > water)
                {
                    currentFlower -= water;

                    var temp = flowers.ToList();
                    temp.Insert(0, currentFlower);
                    flowers = new Queue<int>(temp);
                }
            }

            Console.WriteLine(flowers.Count != 0 ? string.Join(" ", flowers) : string.Join(" ", watterSup));
            Console.WriteLine(secondNature.Count > 0 ? string.Join(" ", secondNature) : "None");
        }
    }
}
