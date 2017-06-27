using System;

namespace Longer_Line
{
    public class LongerLine
    {
        public static void Main()
        {
            double firstLineX1 = double.Parse(Console.ReadLine());
            double firstLineY1 = double.Parse(Console.ReadLine());
            double firstLineX2 = double.Parse(Console.ReadLine());
            double firstLineY2 = double.Parse(Console.ReadLine());
            double secondLineX1 = double.Parse(Console.ReadLine());
            double secondLineY1 = double.Parse(Console.ReadLine());
            double secondLineX2 = double.Parse(Console.ReadLine());
            double secondLineY2 = double.Parse(Console.ReadLine());
            double firstLineLenght = GetLongerLine(firstLineX1, firstLineY1, firstLineX2, firstLineY2);
            double secondLineLenght = GetLongerLine(secondLineX1, secondLineY1, secondLineX2, secondLineY2);
            if (firstLineLenght >= secondLineLenght)
            {
                double firstPoint = GetClosedToCenter(firstLineX1, firstLineY1);
                double secondPoint = GetClosedToCenter(firstLineX2, firstLineY2);
                if (firstPoint > secondPoint)
                {
                    Console.WriteLine($"({firstLineX2}, {firstLineY2})({firstLineX1}, {firstLineY1})");
                }
                else
                {
                    Console.WriteLine($"({firstLineX1}, {firstLineY1})({firstLineX2}, {firstLineY2})");
                }
            }
            else
            {
                double firstPoint = GetClosedToCenter(secondLineX1, secondLineY1);
                double secondPoint = GetClosedToCenter(secondLineX2, secondLineY2);
                if (firstPoint > secondPoint)
                {
                    Console.WriteLine($"({secondLineX2}, {secondLineY2})({secondLineX1}, {secondLineY1})");
                }
                else
                {
                    Console.WriteLine($"({secondLineX1}, {secondLineY1})({secondLineX2}, {secondLineY2})");
                }
            }
        }

        public static double GetClosedToCenter(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }

        public static double GetLongerLine(double lineX1, double lineY1, double lineX2, double lineY2)
        {
            double lenghtX = Math.Abs(lineX1 - lineX2);
            double lenghtY = Math.Abs(lineY1 - lineY2);
            double result = Math.Sqrt(Math.Pow(lenghtX, 2) + Math.Pow(lenghtY, 2));
            return result;
        }
    }
}
