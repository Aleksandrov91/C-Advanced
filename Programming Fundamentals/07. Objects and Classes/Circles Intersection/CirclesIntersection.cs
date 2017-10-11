using System;
using System.Linq;

namespace Circles_Intersection
{
    public class CirclesIntersection
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var secondLine = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var firstCircle = new Circle
            {
                CenterX = firstLine[0],
                CenterY = firstLine[1],
                Radius = firstLine[2]
            };

            var secondCircle = new Circle
            {
                CenterX = secondLine[0],
                CenterY = secondLine[1],
                Radius = secondLine[2]
            };

            var distance = GetDistance(firstCircle, secondCircle);
            Console.WriteLine(IsIntersect(distance, firstCircle, secondCircle) ? "Yes" : "No");
        }

        public static double GetDistance(Circle firstCircle, Circle secondCircle)
        {
            var a = Math.Pow(firstCircle.CenterX - secondCircle.CenterX, 2);
            var b = Math.Pow(firstCircle.CenterY - secondCircle.CenterY, 2);
            var result = Math.Sqrt(a + b);
            return result;
        }

        public static bool IsIntersect(double distance, Circle firstCircle, Circle secondCircle)
        {
            if (distance <= (firstCircle.Radius + secondCircle.Radius))
            {
                return true;
            }

            return false;
        }
    }
}
