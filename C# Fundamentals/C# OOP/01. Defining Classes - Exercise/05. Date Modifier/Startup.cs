namespace _05.Date_Modifier
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            Console.WriteLine(DateModifier.CalculateDifference(firstDate, secondDate));
        }
    }
}
