namespace Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main()
        {
            var keyMaterials = new Dictionary<string,int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;
            var junkMaterials = new SortedDictionary<string,int>();
            var legendaryObtained = false;
            var input = Console.ReadLine();

            while (true)
            {
                var inputParams = input.Split();
                for (int i = 0; i < inputParams.Length; i++)
                {
                    var quantity = int.Parse(inputParams[i]);
                    var material = inputParams[i + 1].ToLower();
                    i++;

                    if (material == "motes" || material == "shards" || material == "fragments")
                    {
                        

                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if(material =="fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }

                            keyMaterials[material] -= 250;

                            foreach (var element in keyMaterials.OrderByDescending(x=>x.Value).ThenBy(y=>y.Key))
                            {
                                Console.WriteLine($"{element.Key}: {element.Value}");
                            }

                            foreach (var element in junkMaterials)
                            {
                                Console.WriteLine($"{element.Key}: {element.Value}");
                            }
                            legendaryObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }
                }

                if (legendaryObtained)
                {
                    break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
