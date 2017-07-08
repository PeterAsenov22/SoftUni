namespace Vehicles
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Car car = null;
            Truck truck = null;
            Bus bus = null;

            for (int i = 0; i < 3; i++)
            {
                var vehicleParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var fuelQuantity = double.Parse(vehicleParams[1]);
                var fuelConsumption = double.Parse(vehicleParams[2]);
                var tankCapacity = double.Parse(vehicleParams[3]);

                switch (vehicleParams[0])
                {
                    case "Car":
                        car = new Car(fuelQuantity, fuelConsumption, tankCapacity);
                        break;
                    case "Truck":
                        truck = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                        break;
                    case "Bus":
                        bus = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                        break;
                }
            }

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                try
                {
                    var command = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    if (command[0] == "Drive")
                    {
                        if (command[1] == "Car")
                        {
                            var driving = car.Drive(double.Parse(command[2]));
                            Console.WriteLine(driving);
                        }
                        else if (command[1] == "Truck")
                        {
                            var driving = truck.Drive(double.Parse(command[2]));
                            Console.WriteLine(driving);
                        }
                        else
                        {
                            var driving = bus.Drive(double.Parse(command[2]));
                            Console.WriteLine(driving);
                        }
                    }
                    else if (command[0] == "Refuel")
                    {
                        if (command[1] == "Car")
                        {
                            car.Refill(double.Parse(command[2]));
                        }
                        else if (command[1] == "Truck")
                        {
                            truck.Refill(double.Parse(command[2]));
                        }
                        else
                        {
                            bus.Refill(double.Parse(command[2]));
                        }
                    }
                    else
                    {
                        var driving = bus.DriveEmpty(double.Parse(command[2]));
                        Console.WriteLine(driving);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
