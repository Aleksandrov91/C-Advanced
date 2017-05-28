using System;

namespace Greater_of_Two_Values
{
    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string dataType = Console.ReadLine();
            if (dataType == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (dataType == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (dataType == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a, b));
            }
        }

        public static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        public static char GetMax(char a, char b)
        {
            return (char)GetMax((int)a, (int)b);
        }

        public static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) >= 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
