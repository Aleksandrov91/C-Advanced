using System;

namespace Geometry_Calculator
{
    public class GeometryCalculator
    {
        public static void Main()
        {
            string geometryType = Console.ReadLine();
            if (geometryType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                GetTriangleArea(side, height);
            }
            else if (geometryType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                GetSquareArea(side);
            }
            else if (geometryType == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                GetRectangleArea(a, b);
            }
            else if (geometryType == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                GetCircleArea(r);
            }
        }
        public static void GetTriangleArea(double side, double height)
        {
            double area = 0.5 * side * height;
            Console.WriteLine("{0:f2}", area);
        }

        public static void GetSquareArea(double side)
        {
            double area = side * side;
            Console.WriteLine("{0:f2}", area);
        }

        public static void GetRectangleArea(double a, double b)
        {
            double area = a * b;
            Console.WriteLine("{0:f2}", area);
        }

        public static void GetCircleArea(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("{0:f2}", area);
        }
    }
}
