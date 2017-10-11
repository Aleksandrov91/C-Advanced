namespace _08.Raw_Data
{
    public class Tire
    {
        private double pressure;
        private int age;

        public Tire(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }

        public double Pressure
        {
            get { return this.pressure; }
        }
    }
}
