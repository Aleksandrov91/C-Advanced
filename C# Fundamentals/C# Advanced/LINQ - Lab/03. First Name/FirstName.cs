namespace _03.First_Name
{
    using System;
    using System.Linq;

    public class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split(' ');
            var letters = Console.ReadLine()
                .Split(' ')
                .OrderBy(x => x);

            var result = string.Empty;
            foreach (var letter in letters)
            {
                result = names
                        .Where(w => w.ToLower()
                        .StartsWith(letter.ToLower()))
                        .FirstOrDefault();

                if (result != null)
                {
                    Console.WriteLine(result);
                    return;
                }
            }

            Console.WriteLine("No match");
        }
    }
}
