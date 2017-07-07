namespace Speed_Racing
{
    using System;

    public class Car
    {
        private string model;
        private double fuel;
        private double consumption;
        private double distance;

        public Car(string model, double fuel, double consumption)
        {
            this.Model = model;
            this.FuelAmount = fuel;
            this.FuelConsumption = consumption;
            this.DistanceTraveled = 0;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }

        public double FuelConsumption
        {
            get { return this.consumption; }
            set { this.consumption = value; }
        }

        public double DistanceTraveled
        {
            get { return this.distance; }
            set { this.distance = value; }
        }

        public void Drive(double km)
        {
            if (this.FuelConsumption * km <= this.FuelAmount)
            {
                this.DistanceTraveled += km;
                this.FuelAmount -= this.FuelConsumption * km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
