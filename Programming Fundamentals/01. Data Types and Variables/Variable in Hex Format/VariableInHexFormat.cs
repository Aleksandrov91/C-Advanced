using System;

namespace Variable_in_Hex_Format
{
    public class VariableInHexFormat
    {
        public static void Main()
        {
            string hex = Console.ReadLine();
            int number = Convert.ToInt32(hex, 16);
            Console.WriteLine(number);
        }
    }
}
