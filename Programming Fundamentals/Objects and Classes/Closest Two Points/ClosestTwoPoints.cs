using System;
using System.Collections.Generic;
using System.Linq;

namespace Closest_Two_Points
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = Console.ReadLine().Split().Select(double.Parse).ToArray();

                points.Add(new Point
                {
                    X = currentPoint[0],
                    Y = currentPoint[1]
                });
            }

            FindClosestPoint(points);
        }
        
        public static void FindClosestPoint(List<Point> points)
        {
            var minDistance = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;
            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];
                    var currentDistance = GetNearestPoint(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");
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
