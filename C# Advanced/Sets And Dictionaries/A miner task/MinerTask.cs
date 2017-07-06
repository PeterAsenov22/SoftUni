namespace A_miner_task
{
    using System;
    using System.Collections.Generic;

    public class MinerTask
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string,long>();
            var material = Console.ReadLine();

            while (material!="stop")
            {
                var quantity = long.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(material))
                {
                    dictionary[material] = 0;
                }

                dictionary[material] += quantity;

                material = Console.ReadLine();
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
