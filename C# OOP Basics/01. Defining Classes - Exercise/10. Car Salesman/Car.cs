namespace _10.Car_Salesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public string Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public override string ToString()
        {
            return
                $"{this.model}:\r\n\t{this.engine.Model}:\r\n\t\tPower: {this.engine.Power}\r\n\t\tDisplacement: {this.engine.Displacement}\r\n\t\tEfficiency: {this.engine.Efficiency}\r\n\t\tWeight: {this.Weight}\r\n\t\tColor: {this.Color}";
        }
    }
}
