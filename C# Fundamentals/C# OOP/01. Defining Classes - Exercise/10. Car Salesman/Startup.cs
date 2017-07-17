namespace _10.Car_Salesman
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var engineNumber = int.Parse(Console.ReadLine());
            var engines = new Dictionary<string, Engine>();
            var cars = new List<Car>();

            for (int i = 0; i < engineNumber; i++)
            {
                var engineInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var engineModel = engineInfo[0];
                var enginePower = int.Parse(engineInfo[1]);

                var engine = new Engine(engineModel, enginePower);

                if (engineInfo.Length > 2)
                {
                    var displacement = 0;

                    if (int.TryParse(engineInfo[2], out displacement))
                    {
                        engine.Displacement = engineInfo[2];
                    }
                    else
                    {
                        engine.Efficiency = engineInfo[2];
                    }
                }

                if (engineInfo.Length > 3)
                {
                    engine.Efficiency = engineInfo[3];
                }

                engines.Add(engineModel, engine);
            }

            var carsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsNumber; i++)
            {
                var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var carModel = carInfo[0];
                var engineModel = engines[carInfo[1]];

                var car = new Car(carModel, engineModel);

                if (carInfo.Length > 2)
                {
                    var weight = 0;
                    if (int.TryParse(carInfo[2], out weight))
                    {
                        car.Weight = carInfo[2];
                    }
                    else
                    {
                        car.Color = carInfo[2];
                    }
                }

                if (carInfo.Length > 3)
                {
                    car.Color = carInfo[3];
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
