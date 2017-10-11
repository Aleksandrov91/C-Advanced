namespace _09.Traffic_Lights
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(' ')
                .Select(t => (TrafficLights)Enum.Parse(typeof(TrafficLights), t))
                .ToArray();

            var numberOfCharges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCharges; i++)
            {
                for (int j = 0; j < inputLine.Length; j++)
                {
                    inputLine[j] = (TrafficLights)(((int)inputLine[j] + 1) % 3);
                    Console.Write(inputLine[j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
