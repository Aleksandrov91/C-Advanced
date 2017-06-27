namespace _02.Upper_Strings
{
    using System;
    using System.Linq;

    public class UpperStrings
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(' ')
                .Select(x => x.ToUpper())
                .ToList()
                .ForEach(w => Console.Write(w + " "));
        }
    }
}
