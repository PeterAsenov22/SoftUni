namespace Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RawData
    {
        public static void Main()
        {
            var cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputPrms = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var model = inputPrms[0];
                var engine = new Engine(int.Parse(inputPrms[1]),int.Parse(inputPrms[2]));
                var cargo = new Cargo(int.Parse(inputPrms[3]),inputPrms[4]);
                var tires = new List<Tire>();

                for (int j = 0; j < 4; j++)
                {
                    var tire = new Tire(double.Parse(inputPrms[5+2*j]),int.Parse(inputPrms[6+2*j]));
                    tires.Add(tire);
                }

                var car  = new Car(model,engine,cargo,tires);
                cars.Add(car);
            }

            var command = Console.ReadLine();
            if (command == "fragile")
            {
                var filtered = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1)).ToList();
                foreach (var car in filtered)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                var filtered = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).ToList();
                foreach (var car in filtered)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
