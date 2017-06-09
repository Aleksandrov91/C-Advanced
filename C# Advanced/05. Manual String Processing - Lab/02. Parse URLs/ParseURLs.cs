using System;

namespace _02.Parse_URLs
{
    public class ParseURLs
    {
        public static void Main()
        {
            var url = Console.ReadLine();

            var urlArgs = url.Split(new[] {"://"}, StringSplitOptions.RemoveEmptyEntries);

            if (urlArgs.Length != 2 || !urlArgs[1].Contains("/"))
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var slashIndex = urlArgs[1].IndexOf('/');
            var protocol = urlArgs[0];
            var server = urlArgs[1].Substring(0, slashIndex);
            var resources = urlArgs[1].Substring(slashIndex + 1);

            Console.WriteLine($"Protocol = {protocol}");
            Console.WriteLine($"Server = {server}");
            Console.WriteLine($"Resources = {resources}");

        }
    }
}
