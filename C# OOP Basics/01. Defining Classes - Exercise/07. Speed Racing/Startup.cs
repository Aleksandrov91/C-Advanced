namespace _07.Speed_Racing
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var cars = new Dictionary<string, Car>();

            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var carsData = Console.ReadLine().Split(' ');
                var carModel = carsData[0];
                var fuelAmount = int.Parse(carsData[1]);
                var fuelConsumption = double.Parse(carsData[2]);

                if (!cars.ContainsKey(carModel))
                {
                    cars[carModel] = new Car(carModel, fuelAmount, fuelConsumption);
                }
            }

            var commands = Console.ReadLine();

            while (commands != "End")
            {
                var commandArgs = commands.Split(' ');

                var carModel = commandArgs[1];
                var distance = int.Parse(commandArgs[2]);

                if (cars.ContainsKey(carModel))
                {
                    cars[carModel].Drive(distance);
                }

                commands = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Value.ToString());
            }
        }
    }
}
