namespace _05.Pizza_Calories
{
    using System;
    using System.Linq;

    public class Pizza
    {
        private int index = 0;
        private string name;
        private Topping[] toppings;
        private Dough dough;

        public Pizza(string name, int toppings)
        {
            this.Name = name;
            this.Toppings = new Topping[toppings];
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if ((string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) && value.Length <= 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Topping[] Toppings
        {
            get
            {
                return this.toppings;
            }

            private set
            {
                if (value.Length < 0 || value.Length > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this.toppings = value;
            }
        }

        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }

        public void AddToping(Topping topping)
        {
            this.Toppings[this.index] = topping;
            this.index++;
        }

        public double PizzaCalories()
        {
            var doughCalories = this.dough.CalculateDoughCalories();
            var toppingCalories = 0.0;
            if (this.toppings.Length != 0)
            {
                toppingCalories = this.toppings.Sum(t => t.CalculateToppingCalories());
            }

            return doughCalories + toppingCalories;
        }
    }
}