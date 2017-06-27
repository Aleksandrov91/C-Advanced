using System;

namespace Reverse_Characters
{
    public class ReverseCharacters
    {
        public static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string oldA = a;
            a = c;
            c = oldA;
            Console.WriteLine($"{a}{b}{c}");
        }
    }
}
