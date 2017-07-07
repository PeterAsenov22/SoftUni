namespace Car_Salesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CarSalesman
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var engineParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (engineParams.Length == 2)
                {
                    var engine = new Engine(engineParams[0],int.Parse(engineParams[1]));
                    engines.Add(engine);
                }
                else if(engineParams.Length==3)
                {
                    int displacement;
                    bool isParsed = int.TryParse(engineParams[2], out displacement);
                    if (isParsed)
                    {
                        var engine = new Engine(engineParams[0], int.Parse(engineParams[1]),displacement);
                        engines.Add(engine);
                    }
                    else
                    {
                        var engine = new Engine(engineParams[0], int.Parse(engineParams[1]),engineParams[2]);
                        engines.Add(engine);
                    }
                }
                else
                {
                    var engine = new Engine(engineParams[0], int.Parse(engineParams[1]), int.Parse(engineParams[2]),engineParams[3]);
                    engines.Add(engine);
                }
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                var carParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (carParams.Length == 2)
                {
                    var engine = engines.First(x => x.Model == carParams[1]);
                    var car  = new Car(carParams[0],engine);
                    cars.Add(car);
                }
                else if (carParams.Length == 3)
                {
                    var engine = engines.First(x => x.Model == carParams[1]);
                    double weight;
                    bool isParsed = double.TryParse(carParams[2], out weight);
                    if (isParsed)
                    {
                        var car = new Car(carParams[0], engine, weight);
                        cars.Add(car);
                    }
                    else
                    {
                        var car = new Car(carParams[0], engine, carParams[2]);
                        cars.Add(car);
                    }
                }
                else
                {
                    var engine = engines.First(x => x.Model == carParams[1]);
                    var car = new Car(carParams[0],engine,double.Parse(carParams[2]),carParams[3]);
                    cars.Add(car);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {(car.Engine.Displacement == null ? "n/a" : car.Engine.Displacement.ToString()) }");             
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency ?? "n/a"}");
                Console.WriteLine($"  Weight: {(car.Weight == null ? "n/a" : car.Weight.ToString())}");
                Console.WriteLine($"  Color: {car.Color ?? "n/a"}");
            }
        }
    }
}
