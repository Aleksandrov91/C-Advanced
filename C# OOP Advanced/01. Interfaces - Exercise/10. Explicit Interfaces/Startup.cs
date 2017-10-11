namespace _10.Explicit_Interfaces
{
    using System;
    using Interfaces;

    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var inputData = inputLine.Split(' ');
                var citizen = new Citizen(inputData[0], inputData[1], int.Parse(inputData[2]));

                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
                
                inputLine = Console.ReadLine();
            }
        }
    }
}
