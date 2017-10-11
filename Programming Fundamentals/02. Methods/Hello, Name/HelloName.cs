using System;

namespace Hello__Name
{
    public class HelloName
    {
        public static void Main()
        {
            GetFirstName("Peter");
        }

        public static void GetFirstName(string firstName)
        {
            Console.WriteLine($"Hello, {firstName}!");
        }
    }
}
