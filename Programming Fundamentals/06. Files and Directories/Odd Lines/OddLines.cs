using System.Collections.Generic;
using System.IO;

namespace Odd_Lines
{
    public class OddLines
    {
        public static void Main()
        {
            var text = File.ReadAllLines("input.txt");
            var result = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(text[i]);
                }
            }

            File.WriteAllText("result.txt", string.Join("\r\n", result));
        }
    }
}
