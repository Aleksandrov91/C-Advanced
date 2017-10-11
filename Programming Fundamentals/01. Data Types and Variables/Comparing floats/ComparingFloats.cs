using System;

namespace Comparing_floats
{
    public class ComparingFloats
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool isEquals = true;
            double difference = Math.Abs(firstNumber - secondNumber);
            if (difference < eps)
            {
                isEquals = true;
            }
            else
            {
                isEquals = false;
            }

            Console.WriteLine(isEquals);
        }
    }
}
