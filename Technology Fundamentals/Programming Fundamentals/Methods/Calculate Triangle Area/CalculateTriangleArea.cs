using System;

namespace Calculate_Triangle_Area
{
    public class CalculateTriangleArea
    {
        public static void Main()
        {
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double result = GetTriagneArea(triangleSide, triangleHeight);
            Console.WriteLine(result);
        }

        public static double GetTriagneArea(double triangleSide, double triangleHeight)
        {
            double area = (triangleHeight * triangleSide) / 2;
            return area;
        }
    }
}
