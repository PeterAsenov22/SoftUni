namespace Ashes_of_Roses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class AshesOfRoses
    {
        public static void Main()
        {
            var regions = new Dictionary<string,Dictionary<string,long>>();
            var regex = new Regex(@"^Grow\s<([A-Z][a-z]+)>\s<([A-Za-z0-9]+)>\s(\d+)$");
            var input = Console.ReadLine();
            while (input!= "Icarus, Ignite!")
            {
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    var regionName = match.Groups[1].Value;
                    var colorName = match.Groups[2].Value;
                    var roseAmount = long.Parse(match.Groups[3].Value);

                    if (!regions.ContainsKey(regionName))
                    {
                        regions[regionName] = new Dictionary<string, long>();
                    }

                    if (!regions[regionName].ContainsKey(colorName))
                    {
                        regions[regionName][colorName] = 0;
                    }

                    regions[regionName][colorName] += roseAmount;
                }
                input = Console.ReadLine();
            }

            foreach (var region in regions.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                Console.WriteLine(region.Key);
                foreach (var color in region.Value.OrderBy(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"*--{color.Key} | {color.Value}");
                }
            }
        }
    }
}
