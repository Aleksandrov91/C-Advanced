namespace _06.Animals
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var animals = new List<Animal>();
            var animalType = Console.ReadLine();

            while (animalType != "Beast!")
            {
                var animalData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    var currentAnimal = AnimalFactory.CreateAnimal(animalType, animalData);
                    animals.Add(currentAnimal);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                animalType = Console.ReadLine();
            }

            PrintAnimals(animals);
        }

        private static void PrintAnimals(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.Write(animal);
            }
        }
    }
}
