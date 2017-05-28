using System;

namespace Count_Substring_Occurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var line = Console.ReadLine().ToLower();
            var count = 0;
            var index = text.IndexOf(line);
            while (true)
            {
                if (index >= 0)
                {
                    count++;
                    index = text.IndexOf(line, index + 1);

                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
