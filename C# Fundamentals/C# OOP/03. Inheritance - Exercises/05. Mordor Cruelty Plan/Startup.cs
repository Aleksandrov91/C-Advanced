namespace _05.Mordor_Cruelty_Plan
{
    using System;
    using FoodModel;

    public class Startup
    {
        public static void Main()
        {
            var foodLine = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var gandalf = new Gandalf();

            foreach (var food in foodLine)
            {
                gandalf.AddFood(FoodFactory.CreateFood(food));
            }

            Console.WriteLine(gandalf);
        }
    }
}
