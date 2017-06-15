using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _02.Knights_of_Honor
{
    public class KnightsOfHonor
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(' ');

            Action<string> printWithPrefix = w => Console.WriteLine($"Sir {w}");
            Foreach(names, printWithPrefix);
        }

        public static void Foreach(string[] names, Action<string> prefix)
        {
            foreach (var name in names)
            {
                prefix(name);
            }
        }
    }
}
