namespace _04.Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public IList<Product> Bag
        {
            get { return this.bag.AsReadOnly(); }
        }

        public bool BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                return false;
            }
            else
            {
                this.Money -= product.Cost;
                this.bag.Add(product);
                return true;
            }
        }
    }
}