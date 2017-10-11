namespace _01.Vehicles
{
    using System;

    public class Bus : Vehicle
    {
        private double airConditionConst = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity)
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

        protected override bool Drive(double distance, bool isAcOn)
        {
            if (!isAcOn)
            {
                this.airConditionConst = 0;
            }

            return base.Drive(distance, isAcOn);
        }
    }
}
