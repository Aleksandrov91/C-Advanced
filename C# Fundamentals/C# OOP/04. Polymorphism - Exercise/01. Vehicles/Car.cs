namespace _01.Vehicles
{
    using System;

    public class Car : Vehicle
    {
        private double airConditionConst = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, int tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AirConditionConst
        {
            get { return this.airConditionConst; }
        }

        public override void Refuel(double refuelCount)
        {
            if (this.TankCapacity < refuelCount)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }

            base.Refuel(refuelCount);
        }
    }
}
