namespace _03.Wild_farm.AnimalModel
{
    using Model;

    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string name, string type, double weight, string livingRegion)
            : base(name, type, weight)
        {
            this.livingRegion = livingRegion;
        }

        protected string LivingRegion
        {
            get { return this.livingRegion; }
        }

        public override string ToString()
        {
            return $"{this.Type}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
