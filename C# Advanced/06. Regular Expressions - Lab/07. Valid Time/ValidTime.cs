using System;
using System.Text.RegularExpressions;

namespace _07.Valid_Time
{
    public class ValidTime
    {
        public static void Main()
        {
            var pattern = @"([01][0-9]):[0-5][0-9]:[0-5][0-9] (A|P)M";
            var input = Console.ReadLine();

            while (input != "END")
            {
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    if (IsValid(match.Groups[1].ToString()))
                    {
                        Console.WriteLine("valid");
                    }
                    else
                    {
                        Console.WriteLine("invalid");
                    }
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }

        private static bool IsValid(string hours)
        {
            var hoursNum = int.Parse(hours);

            if (hoursNum > 12)
            {
                return false;
            }

            return true;
        }
    }
}
