namespace _01.Action_Print
{
    using System;
    using System.Linq;

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
