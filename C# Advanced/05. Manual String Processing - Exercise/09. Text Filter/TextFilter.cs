using System;
using System.Text.RegularExpressions;

namespace _09.Text_Filter
{
    public class TextFilter
    {
        public static void Main()
        {
            string[] banList = Console.ReadLine().Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            for (int i = 0; i < banList.Length; i++)
            {
                text = Regex.Replace(text, banList[i], new string('*', banList[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
