namespace _06.Animals
{
    using System;
    using Model;

    public class AnimalFactory
    {
        public static Animal CreateAnimal(string animalType, string[] animalData)
        {
            switch (animalType)
            {
                case "Dog":
                    return new Dog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                case "Cat":
                    return new Cat(animalData[0], int.Parse(animalData[1]), animalData[2]);
                case "Frog":
                    return new Frog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                case "Kitten":
                    return new Kitten(animalData[0], int.Parse(animalData[1]), animalData[2]);
                case "Tomcat":
                    return new Tomcat(animalData[0], int.Parse(animalData[1]), animalData[2]);
                default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}
