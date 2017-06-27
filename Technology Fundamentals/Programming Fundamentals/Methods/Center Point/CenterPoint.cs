using System;

namespace Center_Podouble
{
    public class CenterPodouble
    {
        public static void Main()
        {
            double firstPointX = double.Parse(Console.ReadLine());
            double firstPointY = double.Parse(Console.ReadLine());
            double secondPointX = double.Parse(Console.ReadLine());
            double secondPointY = double.Parse(Console.ReadLine());
            double firstPoint = GetClosedToCenter(firstPointX, firstPointY);
            double secondPoint = GetClosedToCenter(secondPointX, secondPointY);

            if (firstPoint >= secondPoint)
            {
                Console.WriteLine($"({secondPointX}, {secondPointY})");
            }
            else
            {
                Console.WriteLine($"({firstPointX}, {firstPointY})");
            }
        }

        public static double GetClosedToCenter(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }
    }
}
