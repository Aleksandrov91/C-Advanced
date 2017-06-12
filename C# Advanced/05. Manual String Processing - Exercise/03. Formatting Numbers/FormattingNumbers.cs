namespace _03.Formatting_Numbers
{
    using System;

    public class FormattingNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var hexNum = int.Parse(numbers[0]).ToString("X");
            var num = int.Parse(numbers[0]);
            var binaryNum = Convert.ToString(num, 2).PadLeft(10, '0').Substring(0, 10);
            var secondNum = double.Parse(numbers[1]).ToString("F2");
            var thirdNum = double.Parse(numbers[2]).ToString("F3");

            Console.WriteLine($"|{hexNum,-10}|{binaryNum}|{secondNum,10}|{thirdNum,-10}|");
        }
    }
}
