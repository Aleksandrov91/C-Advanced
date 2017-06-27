using System;

namespace Print_Part_Of_ASCII_Table
{
    public class PrintASCIITable
    {
        public static void Main()
        {
            int firstCharacter = int.Parse(Console.ReadLine());
            int secondCharacter = int.Parse(Console.ReadLine());
            for (int i = firstCharacter; i <= secondCharacter; i++)
            {
                char convertedToASCII = (char)i;
                Console.Write($"{convertedToASCII} ");
            }
        }
    }
}
