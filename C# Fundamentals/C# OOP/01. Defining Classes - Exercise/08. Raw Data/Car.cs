namespace _08.Raw_Data
{
    using System.Collections.Generic;
    
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.Tires = new List<Tire>();
        }

        public string Model
        {
            get { return this.model; }
        }

        public Engine Engine
        {
            get { return this.engine; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
        }

        public List<Tire> Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }
    }
}
