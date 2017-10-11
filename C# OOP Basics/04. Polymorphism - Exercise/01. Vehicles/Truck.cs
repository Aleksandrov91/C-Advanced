namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private double airConditionConst = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, int tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AirConditionConst
        {
            get { return this.airConditionConst; }
        }

        public override void Refuel(double refuelCount)
        {
            base.Refuel(refuelCount * 0.95);
        }
    }
}
