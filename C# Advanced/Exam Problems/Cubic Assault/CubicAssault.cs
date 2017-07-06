namespace Cubic_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class CubicAssault
    {
        public static void Main()
        {
            var regions = new List<Region>();
            var input = Console.ReadLine();
            while (input!="Count em all")
            {
                var inputParams = input.Split(new[] {"->"}, StringSplitOptions.RemoveEmptyEntries);
                var regionName = inputParams[0].Trim();
                var metheorType = inputParams[1].Trim();
                var count = BigInteger.Parse(inputParams[2].Trim());

                if (regions.Any(x => x.Name == regionName))
                {
                    var curr = regions.First(x => x.Name == regionName);
                    if (metheorType == "Green")
                    {
                        curr.Green += count;
                    }
                    else if (metheorType == "Red")
                    {
                        curr.Red += count;
                    }
                    else if (metheorType == "Black")
                    {
                        curr.Black += count;
                    }

                    if (curr.Green >= 1000000)
                    {
                        var redToAdd = curr.Green / 1000000;
                        curr.Green = curr.Green % 1000000;
                        curr.Red += redToAdd;
                    }

                    if (curr.Red >= 1000000)
                    {
                        var blackToAdd = curr.Red / 1000000;
                        curr.Red = curr.Red % 1000000;
                        curr.Black += blackToAdd;
                    }
                }
                else
                {
                    var region = new Region()
                    {
                        Name = regionName,
                        Black = 0,
                        Red = 0,
                        Green = 0
                    };

                    if (metheorType == "Green")
                    {
                        region.Green = count;
                        if (region.Green >= 1000000)
                        {
                            var redToAdd = region.Green / 1000000;
                            region.Green = region.Green % 1000000;
                            region.Red += redToAdd;
                        }
                    }
                    else if (metheorType == "Red")
                    {
                        if (region.Red >= 1000000)
                        {
                            var blackToAdd = region.Red / 1000000;
                            region.Red = region.Red % 1000000;
                            region.Black += blackToAdd;
                        }
                        region.Red = count;
                    }
                    else if (metheorType == "Black")
                    {
                        region.Black = count;
                    }

                    regions.Add(region);
                }
                input = Console.ReadLine();
            }

            foreach (var region in regions.OrderByDescending(x=>x.Black).ThenBy(x=>x.Name.Length).ThenBy(x=>x.Name))
            {
                Console.WriteLine(region.Name);
                var dict = new Dictionary<string,BigInteger>();
                dict["Green"] = region.Green;
                dict["Red"] = region.Red;
                dict["Black"] = region.Black;

                foreach (var type in dict.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"-> {type.Key} : {type.Value}");
                }
            }
        }
    }
}
