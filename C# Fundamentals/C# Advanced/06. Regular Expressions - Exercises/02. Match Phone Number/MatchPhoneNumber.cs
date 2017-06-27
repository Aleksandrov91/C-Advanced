namespace _02.Match_Phone_Number
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var pattern = @"^\+359(\s|-)\d\1\d{3}\1\d{4}$";
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
