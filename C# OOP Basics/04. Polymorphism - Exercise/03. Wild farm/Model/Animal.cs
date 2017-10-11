namespace _03.Wild_farm.Model
{
    public abstract class Animal
    {
        private string name;
        private string type;
        private double weight;
        private int foodEaten;

        protected Animal(string name, string type, double weight)
        {
            this.name = name;
            this.type = type;
            this.weight = weight;
        }

        protected int FoodEaten
        {
            get { return this.foodEaten; }
        }

        protected double Weight
        {
            get { return this.weight; }
        }

        protected string Type
        {
            get { return this.type; }
        }

        protected string Name
        {
            get { return this.name; }
        }

        public abstract string MakeSound();

        public virtual void Eat(Food food)
        {
            this.foodEaten += food.Quantity;
        }
    }
}
