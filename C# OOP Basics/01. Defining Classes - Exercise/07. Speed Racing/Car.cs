namespace _07.Speed_Racing
{
    using System;

    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double distanceTraveled;

        public Car(string model, int fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.distanceTraveled = 0;
        }

        public void Drive(int distance)
        {
            if (distance * this.fuelConsumption > this.fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }

            this.fuelAmount -= distance * this.fuelConsumption;
            this.distanceTraveled += distance;
        }

        public override string ToString()
        {
            return $"{this.model} {this.fuelAmount:F2} {this.distanceTraveled}";
        }
    }
}
