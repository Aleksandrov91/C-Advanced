namespace _03.Wild_farm.Factory
{
    using System;
    using FoodModel;
    using Model;

    public class FoodFactory
    {
        public static Food CreateFood(string[] foodInfo)
        {
            switch (foodInfo[0].ToLower())
            {
                case "meat":
                    return new Meat(int.Parse(foodInfo[1]));
                case "vegetable":
                    return new Vegetable(int.Parse(foodInfo[1]));
                default:
                    return null;
            }
        }
    }
}
