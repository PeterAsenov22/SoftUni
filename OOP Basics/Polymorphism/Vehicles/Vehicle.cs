namespace Vehicles
{
    using System;

    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.tankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;      
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }

                this.fuelQuantity = value;
            }
        }

        protected double TankCapacity
        {
            get { return this.tankCapacity; }
        }

        protected double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public virtual string Drive(double kilometers)
        {
            if (kilometers * this.fuelConsumption > this.fuelQuantity)
            {
                return $" needs refueling";
            }

            this.FuelQuantity -= this.fuelConsumption * kilometers;
            return $" travelled {kilometers} km";
        }

        public abstract void Refill(double amount);
    }
}
