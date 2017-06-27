namespace _04.Average_of_Doubles
{
    using System;
    using System.Linq;

    public class AverageOfDoubles
    {
        public static void Main()
        {
            var averageSum = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .Average();

            Console.WriteLine($"{averageSum:F2}");
        }
    }
}
