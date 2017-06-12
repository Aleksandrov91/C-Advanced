namespace _02.String_Length
{
    using System;

    public class StringLength
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var filled = input.PadRight(20, '*');

            var result = filled.Substring(0, 20);

            Console.WriteLine(result);
        }
    }
}
