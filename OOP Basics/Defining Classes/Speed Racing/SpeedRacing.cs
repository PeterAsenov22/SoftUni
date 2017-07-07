namespace Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SpeedRacing
    {
        public static void Main()
        {
            var cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var car  = new Car(inputParams[0],double.Parse(inputParams[1]),double.Parse(inputParams[2]));
                cars.Add(car);
            }

            var command = Console.ReadLine();
            while (command!="End")
            {
                var commandParams = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var currentCar = cars.First(x => x.Model == commandParams[1]);
                currentCar.Drive(double.Parse(commandParams[2]));

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
            }
        }
    }
}
