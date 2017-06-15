using System;
using System.Linq;

namespace _01.Action_Print
{
    public class ActionPrint
    {
        public static void Main()
        {
            Action<string> print = w => Console.WriteLine(w);

            Console.ReadLine()
                .Split(' ')
                .ToList()
                .ForEach(w => print(w));
        }
    }
}
