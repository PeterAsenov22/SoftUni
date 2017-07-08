namespace Vehicles
{
    using System;

    public class Car:Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            base.FuelConsumption = fuelConsumption + 0.9;
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
            return "Car" + base.Drive(kilometers);
        }
    }
}
