using System;

namespace Integer_to_Hex_and_Binary
{
    public class IntegerToHexAndBinary
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string hexValue = input.ToString("X");
            string binaryValue = Convert.ToString(input, 2);
            Console.WriteLine(hexValue);
            Console.WriteLine(binaryValue);
        }
    }
}
