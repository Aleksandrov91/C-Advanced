namespace _01.Vehicles
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicle car = new Car(double.Parse(line[1]), double.Parse(line[2]), int.Parse(line[3]));

            line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicle truck = new Truck(double.Parse(line[1]), double.Parse(line[2]), int.Parse(line[3]));

            line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicle bus = new Bus(double.Parse(line[1]), double.Parse(line[2]), int.Parse(line[3]));

            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (command[1] == "Car")
                {
                    ExecuteCommand(car, command[0], double.Parse(command[2]));
                }
                else if (command[1] == "Truck")
                {
                    ExecuteCommand(truck, command[0], double.Parse(command[2]));
                }
                else
                {
                    ExecuteCommand(bus, command[0], double.Parse(command[2]));
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ExecuteCommand(Vehicle vehicle, string vehicleAction, double param)
        {
            try
            {
                switch (vehicleAction)
                {
                    case "Drive":
                        var result = vehicle.TryDrive(param);
                        Console.WriteLine(result);
                        break;
                    case "Refuel":
                        vehicle.Refuel(param);
                        break;
                    case "DriveEmpty":
                        result = vehicle.TryDrive(param, false);
                        Console.WriteLine(result);
                        break;
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
