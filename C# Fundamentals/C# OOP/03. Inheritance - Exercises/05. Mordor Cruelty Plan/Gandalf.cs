namespace _05.Mordor_Cruelty_Plan
{
    using System.Collections.Generic;
    using FoodModel;
    using MoodModel;

    public class Gandalf
    {
        private List<Food> foods;

        public Gandalf()
        {
            this.foods = new List<Food>();
        }

        public void AddFood(Food food)
        {
            this.foods.Add(food);
        }

        public override string ToString()
        {
            return $"{this.CalculateMoodPoints()}\r\n{this.GetMood().GetType().Name}";
        }

        private int CalculateMoodPoints()
        {
            var points = 0;

            foreach (var food in this.foods)
            {
                points += food.FoodFactor;
            }

            return points;
        }

        private Mood GetMood()
        {
            return MoodFactory.CreateMood(this.CalculateMoodPoints());
        }
    }
}
