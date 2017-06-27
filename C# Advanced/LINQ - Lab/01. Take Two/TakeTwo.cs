namespace _01.Take_Two
{
    using System;
    using System.Linq;

    public class TakeTwo
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .Distinct()
                    .Where(x => x >= 10 && x <= 20)
                    .Take(2)));
        }
    }
}
