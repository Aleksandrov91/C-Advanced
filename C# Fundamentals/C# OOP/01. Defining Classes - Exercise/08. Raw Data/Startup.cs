namespace _08.Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var carData = Console.ReadLine().Split(' ');

                var model = carData[0];
                var speed = int.Parse(carData[1]);
                var power = int.Parse(carData[2]);
                var cargoWeight = int.Parse(carData[3]);
                var cargoType = carData[4];

                var engine = new Engine(speed, power);
                var cargo = new Cargo(cargoWeight, cargoType);
                var car = new Car(model, engine, cargo);

                cars.Add(car);

                for (int j = 5, t = 0; j < carData.Length - 1; j += 2, t++)
                {
                    var tirePressure = double.Parse(carData[j]);
                    var tireAge = int.Parse(carData[j + 1]);

                    var tire = new Tire(tirePressure, tireAge);
                    car.Tires.Add(tire);
                }
            }

            var printCommand = Console.ReadLine();

            if (printCommand == "fragile")
            {
                cars.Where(car => car.Cargo.Type == "fragile" && car.Tires.Any(t => t.Pressure < 1))
                     .ToList()
                     .ForEach(c => Console.WriteLine($"{c.Model}"));
            }
            else if (printCommand == "flamable")
            {
                cars.Where(car => car.Engine.Power > 250)
                    .ToList()
                    .ForEach(c => Console.WriteLine($"{c.Model}"));
            }
        }
    }
}
