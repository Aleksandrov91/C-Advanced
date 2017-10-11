namespace _05.Border_Control
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;

    public class Startup
    {
        public static void Main()
        {
            var dwellers = new List<IDweller>();
            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var inputArgs = inputLine.Split(' ');

                if (inputArgs.Length == 2)
                {
                    dwellers.Add(new Robot(inputArgs[0], inputArgs[1]));
                }
                else
                {
                    dwellers.Add(new Citizen(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]));
                }

                inputLine = Console.ReadLine();
            }

            var filter = Console.ReadLine();

            Console.WriteLine(string.Join(Environment.NewLine, dwellers.Where(d => d.Id.EndsWith(filter))));
        }
    }
}
