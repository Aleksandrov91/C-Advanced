namespace _05.Pizza_Calories
{
    using System;

    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }

            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }

            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
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
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double CalculateDoughCalories()
        {
            var flourModifier = 0.0;
            var techniqueModifier = 0.0;

            switch (this.FlourType.ToLower())
            {
                case "white":
                    flourModifier = 1.5;
                    break;

                case "wholegrain":
                    flourModifier = 1.0;
                    break;
            }

            switch (this.BakingTechnique.ToLower())
            {
                case "crispy":
                    techniqueModifier = 0.9;
                    break;

                case "chewy":
                    techniqueModifier = 1.1;
                    break;

                case "homemade":
                    techniqueModifier = 1.0;
                    break;
            }

            return (2 * this.weight) * flourModifier * techniqueModifier;
        }
    }
}