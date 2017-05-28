using System;

namespace Math_Power
{
    public class MathPower
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = GetMathPower(number, power);
            Console.WriteLine(result);
        }

        public static double GetMathPower(double number, int power)
        {
            double result = number;
            for (int i = 1; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
