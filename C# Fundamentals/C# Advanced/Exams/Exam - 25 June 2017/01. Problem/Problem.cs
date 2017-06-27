namespace _01.Problem
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Problem
    {
        public static void Main()
        {
            var secondMatch = @"\[[^\s]+<(\d+)REGEH(\d+)>[^\s]+";
            var input = Console.ReadLine();
            var indexes = new Queue<int>();

            var regex = new Regex(@"(\[(?>[^\[\]]+|(?:1))*\])");
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var extractData = Regex.Matches(match.ToString(), secondMatch);

                foreach (Match data in extractData)
                {
                    indexes.Enqueue(int.Parse(data.Groups[1].ToString()));
                    indexes.Enqueue(int.Parse(data.Groups[2].ToString()));
                }
            }

            var result = new StringBuilder();
            if (indexes.Count == 0)
            {
                return;
            }

            var currentIndex = indexes.Dequeue();
            while (indexes.Count != 0)
            {
                result.Append(input[currentIndex % (input.Length - 1)]);
                currentIndex += indexes.Dequeue();
            }

            result.Append(input[currentIndex % (input.Length - 1)]);
            Console.WriteLine(result);
        }
    }
}
