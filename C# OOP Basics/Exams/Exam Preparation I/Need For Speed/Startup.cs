using System;

public class Startup
{
    public static void Main()
    {
        var s = new CarManager();
        var input = Console.ReadLine();

        while (input != "Cops Are Here")
        {
            var inputData = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = inputData[0];
            ExecuteCommand(s, command, inputData);

            input = Console.ReadLine();
        }
    }

    private static void ExecuteCommand(CarManager s, string operation, string[] input)
    {
        int id = int.Parse(input[1]);

        switch (operation.ToLower())
        {
            case "register":
                string type = input[2];
                string brand = input[3];
                string model = input[4];
                int year = int.Parse(input[5]);
                int horsepower = int.Parse(input[6]);
                int acceleration = int.Parse(input[7]);
                int suspension = int.Parse(input[8]);
                int durability = int.Parse(input[9]);

                s.Register(id, type, brand, model, year, horsepower, acceleration, suspension, durability);
                break;
            case "check":
                var ch = s.Check(id);
                Console.WriteLine(ch);
                break;
            case "open":
                type = input[2];
                int length = int.Parse(input[3]);
                string route = input[4];
                int prizePool = int.Parse(input[5]);

                if (input.Length > 6)
                {
                    var special = int.Parse(input[6]);
                    s.Open(id, type, length, route, prizePool, special);
                    break;
                }

                s.Open(id, type, length, route, prizePool);
                break;
            case "participate":
                int raceId = int.Parse(input[2]);
                s.Participate(id, raceId);
                break;
            case "start":
                var ff = s.Start(id);
                Console.WriteLine(ff);
                break;
            case "park":
                s.Park(id);
                break;
            case "unpark":
                s.UnPark(id);
                break;
            case "tune":
                string tuneAddon = input[2];
                s.Tune(id, tuneAddon);
                break;
        }
    }
}