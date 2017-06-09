using System;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var pattern = @"^[\w-]{3,16}$";
            var input = Console.ReadLine();

            while (input != "END")
            {
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}
