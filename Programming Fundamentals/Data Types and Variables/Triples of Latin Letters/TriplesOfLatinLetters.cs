using System;

namespace Triples_of_Latin_Letters
{
    public class TriplesOfLatinLetters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int firstLetter = 0; firstLetter < n; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < n; secondLetter++)
                {
                    for (int thirdLetter = 0; thirdLetter < n; thirdLetter++)
                    {
                        char firstCharacter = (char)('a' + firstLetter);
                        char secondCharacter = (char)('a' + secondLetter);
                        char thirdCharacter = (char)('a' + thirdLetter);
                        Console.WriteLine($"{firstCharacter}{secondCharacter}{thirdCharacter}");
                    }
                }
            }
        }
    }
}
