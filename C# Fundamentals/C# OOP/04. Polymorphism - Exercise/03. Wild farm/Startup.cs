namespace _03.Wild_farm
{
    using System;
    using Factory;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "End")
            {
                var animalInfo = input.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var foodInfo = Console.ReadLine().Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                var animal = AnimalFactory.CreateAnimal(animalInfo);
                var food = FoodFactory.CreateFood(foodInfo);

                Console.WriteLine(animal.MakeSound());
                try
                {
                    animal.Eat(food);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                Console.WriteLine(animal);

                input = Console.ReadLine();
            }
        }
    }
}
