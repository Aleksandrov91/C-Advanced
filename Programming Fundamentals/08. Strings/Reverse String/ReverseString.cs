using System;
using System.Linq;

namespace Reverse_String
{
    public class ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var result = input.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
