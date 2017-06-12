namespace _01.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            var pattern = @"^[A-Z][a-z]+\s[A-Z][a-z]+$";
            var input = Console.ReadLine();

            while (input != "end")
            {
                var match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }
        }
    }
}
