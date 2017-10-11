namespace _10.Unicode_Characters
{
    using System;
    using System.Text;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                string converted = "\\u" + ((int)input[i]).ToString("x").PadLeft(4, '0');
                result.Append(converted);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
