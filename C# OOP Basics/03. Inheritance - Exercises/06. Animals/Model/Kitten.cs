namespace _06.Animals.Model
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        protected override string Gender
        {
            set
            {
                base.Gender = "Female";
            }
        }

        protected override string ProduceSound()
        {
            return $"Miau";
        }
    }
}
