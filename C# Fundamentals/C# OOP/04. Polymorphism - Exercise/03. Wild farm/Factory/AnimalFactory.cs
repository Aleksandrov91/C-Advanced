namespace _03.Wild_farm.Factory
{
    using AnimalModel;
    using Model;

    public class AnimalFactory
    {
        public static Animal CreateAnimal(string[] data)
        {
            var animalType = data[0];
            var animalName = data[1];
            var animalWeight = double.Parse(data[2]);
            var livingRegion = data[3];

            switch (animalType.ToLower())
            {
                case "mouse":
                    return new Mouse(animalName, animalType, animalWeight, livingRegion);
                case "zebra":
                    return new Zebra(animalName, animalType, animalWeight, livingRegion);
                case "cat":
                    return new Cat(animalName, animalType, animalWeight, livingRegion, data[4]);
                case "tiger":
                    return new Tiger(animalName, animalType, animalWeight, livingRegion);
                default:
                    return null;
            }
        }
    }
}
