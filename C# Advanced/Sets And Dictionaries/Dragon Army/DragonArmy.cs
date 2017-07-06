namespace Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            var dragons = new Dictionary<string, List<Dragon>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split();
                var type = inputParams[0];
                var name = inputParams[1];
                int damage;
                int health;
                int armor;

                if (inputParams[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(inputParams[2]);
                }

                if (inputParams[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(inputParams[3]);
                }

                if (inputParams[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(inputParams[4]);
                }

                
                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new List<Dragon>();
                }

                if (dragons[type].Any(x => x.Type == type && x.Name == name))
                {
                    var currentDragon = dragons[type].First(x => x.Type == type && x.Name == name);
                    currentDragon.Health = health;
                    currentDragon.Armor = armor;
                    currentDragon.Damage = damage;
                }
                else
                {
                    var dragon = new Dragon
                    {
                        Type = type,
                        Name = name,
                        Damage = damage,
                        Health = health,
                        Armor = armor
                    };

                    dragons[type].Add(dragon);
                }
            }

            foreach (var type in dragons)
            {
                double averageArmor = type.Value.Sum(x => x.Armor)/(double)type.Value.Count;
                double averageHealth = type.Value.Sum(x => x.Health)/(double)type.Value.Count;
                double averageDamage = type.Value.Sum(x => x.Damage)/(double)type.Value.Count;

                Console.WriteLine($"{type.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

                foreach (var dragon in type.Value.OrderBy(x=>x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        } 
    }
}
