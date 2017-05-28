using System.Collections.Generic;
using System.IO;

namespace Line_Numbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            var text = File.ReadAllLines("input.txt");
            var result = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                result.Add($"{i + 1}. {text[i]}");
            }

            File.WriteAllText("result.txt", string.Join("\r\n", result));
        }
    }
}
