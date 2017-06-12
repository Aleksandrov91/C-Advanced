namespace _06.Count_Substring_Occurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var searchString = Console.ReadLine().ToLower();
            var count = 0;

            for (int i = 0; i <= text.Length - searchString.Length; i++)
            {
                var currentString = text.Substring(i, searchString.Length);

                if (currentString.Contains(searchString))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
