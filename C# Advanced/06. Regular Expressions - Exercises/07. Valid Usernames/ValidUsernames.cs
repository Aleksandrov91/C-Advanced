namespace _07.Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            var pattern = @"^[a-zA-Z]\w{2,24}$";
            var input = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            var validNames = new Queue<string>();
            var maxCount = 0;
            var firstUserName = string.Empty;
            var secondUserName = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                var match = Regex.Match(input[i], pattern);
                if (match.Success)
                {
                    validNames.Enqueue(match.ToString());
                }
            }

            while (validNames.Count > 1)
            {
                var currentUserName = validNames.Dequeue();
                var nextUserName = validNames.Peek();

                if (currentUserName.Length + nextUserName.Length > maxCount)
                {
                    firstUserName = currentUserName;
                    secondUserName = nextUserName;
                    maxCount = firstUserName.Length + secondUserName.Length;
                }
            }

            Console.WriteLine(firstUserName);
            Console.WriteLine(secondUserName);
        }
    }
}
