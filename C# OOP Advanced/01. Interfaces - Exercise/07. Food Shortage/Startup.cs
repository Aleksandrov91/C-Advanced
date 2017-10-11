namespace _07.Food_Shortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;

    public class Startup
    {
        public static void Main()
        {
            var buyers = new List<IBuyer>();

            var numberOfPeopels = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeopels; i++)
            {
                var inputArgs = Console.ReadLine().Split(' ');

                if (inputArgs.Length == 3)
                {
                    buyers.Add(new Rebel(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]));
                }
                else
                {
                    buyers.Add(new Citizen(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3]));
                }
            }

            var buyer = Console.ReadLine();

            while (buyer != "End")
            {
                if (buyers.Any(b => b.Name == buyer))
                {
                    buyers.FirstOrDefault(b => b.Name == buyer).AddFood();
                }

                buyer = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b => b.FoodCount));
        }
    }
}
