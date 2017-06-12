namespace _15.Melrah_Shake
{
    using System;

    public class MelrahShake
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (inputString.Length > 0 && pattern.Length > 0)
            {
                if (inputString.Contains(pattern))
                {
                    var firstMatch = inputString.IndexOf(pattern);
                    var lastMatch = inputString.LastIndexOf(pattern);
                    inputString = inputString.Remove(firstMatch, pattern.Length);
                    inputString = inputString.Remove(lastMatch - pattern.Length, pattern.Length);
                    pattern = SubstractPattern(pattern);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(inputString);
        }

        private static string SubstractPattern(string pattern)
        {
            return pattern.Remove(pattern.Length / 2, 1);
        }
    }
}
