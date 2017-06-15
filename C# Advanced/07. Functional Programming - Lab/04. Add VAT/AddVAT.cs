using System;
using System.Linq;

namespace _04.Add_VAT
{
    public class AddVAT
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => (n *= 1.2).ToString("F2"))));
        }
    }
}
