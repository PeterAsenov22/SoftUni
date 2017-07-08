namespace Vehicles
{
    using System;

    public class Bus : Vehicle
    {
        private double emptyConsumptionFuel;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            base.FuelConsumption = base.FuelConsumption + 1.4;
            this.emptyConsumptionFuel = fuelConsumption;
        }

        public override void Refill(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (amount + base.FuelQuantity > base.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }

            base.FuelQuantity = base.FuelQuantity + amount;
        }

        public override string Drive(double kilometers)
        {
            return "Bus" + base.Drive(kilometers);
        }

        public string DriveEmpty(double kilometers)
        {
            if (kilometers * this.emptyConsumptionFuel > base.FuelQuantity)
            {
                return $"Bus needs refueling";
            }

            base.FuelQuantity -= this.emptyConsumptionFuel * kilometers;
            return $"Bus travelled {kilometers} km";
        }
    }
}
