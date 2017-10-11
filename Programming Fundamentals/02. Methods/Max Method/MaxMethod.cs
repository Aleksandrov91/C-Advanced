using System;

namespace Max_Method
{
    public class MaxMethod
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int result = GetMax(firstNumber, secondNumber);
            Console.WriteLine(result);
        }

        public static int GetMax(int firstNumber, int secondNumber)
        {
            int thirdNumber = int.Parse(Console.ReadLine());
            int maxNumber = Math.Max(firstNumber, secondNumber);
            return Math.Max(maxNumber, thirdNumber);
        }
    }
}
