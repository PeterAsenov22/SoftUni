namespace Vehicles
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption,tankCapacity)
        {
            base.FuelConsumption = fuelConsumption + 1.6;
        }

        public override void Refill(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            base.FuelQuantity = base.FuelQuantity + amount*0.95;
        }

        public override string Drive(double kilometers)
        {
            return "Truck" + base.Drive(kilometers);
        }
    }
}
