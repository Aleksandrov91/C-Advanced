namespace _01.Vehicles
{
    using System;

    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private int tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            this.tankCapacity = tankCapacity;
        }

        protected double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }

                this.fuelQuantity = value;
            }
        }

        protected int TankCapacity
        {
            get { return this.tankCapacity; }
        }

        protected virtual double AirConditionConst { get; }

        public string TryDrive(double distance, bool isAcOn)
        {
            if (this.Drive(distance, isAcOn))
            {
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public string TryDrive(double distance)
        {
            return this.TryDrive(distance, true);
        }

        public virtual void Refuel(double refuelCount)
        {
            if (refuelCount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            this.fuelQuantity += refuelCount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelQuantity:f2}";
        }

        protected virtual bool Drive(double distance, bool isAcOn)
        {
            var neededFuel = (this.fuelConsumption + this.AirConditionConst) * distance;

            if (this.fuelQuantity >= neededFuel)
            {
                this.fuelQuantity -= neededFuel;
                return true;
            }

            return false;
        }
    }
}
