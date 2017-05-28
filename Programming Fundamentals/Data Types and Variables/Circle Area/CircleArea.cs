using System;

namespace Circle_Area
{
    public class CircleArea
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("{0:F12}", area);
        }
    }
}
