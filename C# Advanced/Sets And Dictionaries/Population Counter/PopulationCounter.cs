namespace Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string,Dictionary<string,long>>();

            while (input!="report")
            {
                var inputParams = input.Split('|');
                var city = inputParams[0];
                var country = inputParams[1];
                var population = long.Parse(inputParams[2]);

                if (!dictionary.ContainsKey(country))
                {
                    dictionary[country] = new Dictionary<string, long>();
                }

                dictionary[country][city] = population;
                input = Console.ReadLine();
            }

            foreach (var country in dictionary.OrderByDescending(x=>x.Value.Sum(y=>y.Value)))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(x=>x.Value)})");

                foreach (var city in country.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
