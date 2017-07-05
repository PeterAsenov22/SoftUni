namespace Map_Districts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MapDistricts
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine().Split(' ');
            var filterNumber = double.Parse(Console.ReadLine());
            var districts = new Dictionary<string, List<double>>();

            for (int i = 0; i < inputParams.Length; i++)
            {
                var currDistrParams = inputParams[i].Split(':');
                var distrName = currDistrParams[0];
                var distrtPopul = double.Parse(currDistrParams[1]);

                if (!districts.ContainsKey(distrName))
                {
                    districts[distrName] = new List<double>();
                }

                districts[distrName].Add(distrtPopul);
            }

            var filteredDistricts = districts.Where(x => x.Value.Sum() >= filterNumber)
                .OrderByDescending(x => x.Value.Sum());

            foreach (var distr in filteredDistricts)
            {
                Console.Write($"{distr.Key}: ");
                Console.WriteLine(string.Join(" ", distr.Value.OrderByDescending(x=>x).Take(5)));
            }
        }
    }
}
