namespace _10.Car_Salesman
{
    public class Engine
    {
        private string model;
        private int power;
        private string displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

        public string Model
        {
            get { return this.model; }
        }

        public int Power
        {
            get { return this.power; }
        }

        public string Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }
    }
}
