namespace _03.Wild_farm.AnimalModel
{
    using System;
    using Model;

    public class Mouse : Mammal
    {
        public Mouse(string name, string type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable")
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }

            base.Eat(food);
        }
    }
}
