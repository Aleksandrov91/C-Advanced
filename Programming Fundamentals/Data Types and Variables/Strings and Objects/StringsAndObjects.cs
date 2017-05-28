using System;

namespace Strings_and_Objects
{
    public class StringsAndObjects
    {
        public static void Main()
        {
            string first = Console.ReadLine();
            string last = Console.ReadLine();
            object fullName = first + " " + last;
            Console.WriteLine(fullName);
        }
    }
}
