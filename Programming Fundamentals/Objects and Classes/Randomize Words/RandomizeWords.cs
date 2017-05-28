using System;

namespace Randomize_Words
{
    public class RandomizeWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var rnd = new Random();

            for (int i = 0; i < input.Length - 1; i++)
            {
                var randomIndex = rnd.Next(0, input.Length);
                var temp = input[i];
                input[i] = input[randomIndex];
                input[randomIndex] = temp;
            }

            Console.WriteLine(string.Join("\n", input));
        }
    }
}
