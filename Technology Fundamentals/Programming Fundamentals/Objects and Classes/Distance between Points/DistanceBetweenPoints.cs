using System;
using System.Linq;

namespace Distance_between_Points
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var secondInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var firstPoint = new Point
            {
                X = firstInput[0],
                Y = firstInput[1]                
            };
            var secondPoint = new Point
            {
                X = secondInput[0],
                Y = secondInput[1]
            };
            var result = GetNearestPoint(firstPoint, secondPoint);
            Console.WriteLine($"{result:F3}");
        }

        public static double GetNearestPoint(Point firstPoint, Point secondPoint)
        {
            var a = firstPoint.X - secondPoint.X;
            var b = firstPoint.Y - secondPoint.Y;
            var diff = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return diff;
        }
    }
}
