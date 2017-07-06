namespace Collect_Resources
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class CollectResources
    {
        public static void Main()
        {
            var materials = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var validElement = new Regex(@"^(wood|food|stone|gold)(?:_(\d+))?$");
            var maxQuantity = 0;
            var numberOfPath = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < numberOfPath; i++)
            {
                var pathParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                var startIndex = pathParams[0];
                var steps = pathParams[1];

                var materialsPaht = new Queue<string>();
                for (int j = 0; j < materials.Length; j++)
                {
                    materialsPaht.Enqueue(materials[j]);
                }


                for (int j = 0; j < startIndex; j++)
                {
                    materialsPaht.Enqueue(materialsPaht.Dequeue());
                }

                var collected = new List<int>();
                var count = 1;
                var quantity = 0;
                var startingMaterial = materialsPaht.Dequeue();
                materialsPaht.Enqueue(startingMaterial);
                if (validElement.IsMatch(startingMaterial))
                {
                    collected.Add(0);
                    var match = validElement.Match(startingMaterial);
                    if (match.Groups[2].Success)
                    {
                        quantity += int.Parse(match.Groups[2].Value);
                    }
                    else
                    {
                        quantity++;
                    }
                }
                
                while (true)
                {
                    for (int j = 0; j < steps-1; j++)
                    {
                        materialsPaht.Enqueue(materialsPaht.Dequeue());
                        count++;
                    }

                    var currentMaterial = materialsPaht.Dequeue();
                    materialsPaht.Enqueue(currentMaterial);

                    if (validElement.IsMatch(currentMaterial))
                    {
                        if (!collected.Contains(count%materials.Length))
                        {
                            collected.Add(count%materials.Length);
                        }
                        else
                        {
                            break;
                        }

                        var match = validElement.Match(currentMaterial);
                        if (match.Groups[2].Success)
                        {
                            quantity += int.Parse(match.Groups[2].Value);
                        }
                        else
                        {
                            quantity++;
                        }
                    }

                    count++;
                }

                if (quantity > maxQuantity)
                {
                    maxQuantity = quantity;
                }
            }

            Console.WriteLine(maxQuantity);
        }
    }
}
