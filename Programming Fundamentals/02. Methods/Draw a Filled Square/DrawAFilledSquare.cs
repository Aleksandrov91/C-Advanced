using System;

namespace Draw_a_Filled_Square
{
    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintHeader(number);
            PrintBody(number);
            PrintHeader(number);
        }

        public static void PrintHeader(int number)
        {
            string header = new string('-', number * 2);
            Console.WriteLine(header);
        }

        public static void PrintBody(int number)
        {
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < number - 1; j++)
                {
                    Console.Write("\\/");
                }

                Console.Write("-");
                Console.WriteLine();
            }
        }
    }
}
