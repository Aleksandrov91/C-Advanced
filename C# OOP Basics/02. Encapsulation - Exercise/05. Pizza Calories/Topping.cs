namespace _05.Pizza_Calories
{
    using System;
    using System.Linq;

    public class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;
        private static string[] toppings = new string[] { "meat", "veggies", "cheese", "sauce" };
        private string toppingType;
        private double weight;

        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        public string ToppingType
        {
            get
            {
                return this.toppingType;
            }

            private set
            {
                if (!toppings.Contains(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.toppingType = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double CalculateToppingCalories()
        {
            var toppingModifier = 0.0;
            switch (this.ToppingType.ToLower())
            {
                case "meat":
                    toppingModifier = 1.2;
                    break;

                case "veggies":
                    toppingModifier = 0.8;
                    break;

                case "cheese":
                    toppingModifier = 1.1;
                    break;

                case "sauce":
                    toppingModifier = 0.9;
                    break;
            }

            return 2 * (this.weight * toppingModifier);
        }
    }
}