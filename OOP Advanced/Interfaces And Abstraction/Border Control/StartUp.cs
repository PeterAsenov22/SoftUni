namespace Border_Control
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var humans = new List<Human>();

            for (int i = 0; i < n; i++)
            {
                var humanInfo = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (humanInfo.Length == 4)
                {
                    var citizen = new Citizen(humanInfo[0],int.Parse(humanInfo[1]),humanInfo[2],humanInfo[3]);
                    humans.Add(citizen);
                }
                else
                {
                    var rebel = new Rebel(humanInfo[0],int.Parse(humanInfo[1]),humanInfo[2]);
                    humans.Add(rebel);
                }
            }

            var name = Console.ReadLine();
            while (name!="End")
            {
                if (humans.Any(x => x.Name == name))
                {
                    var human = humans.First(x => x.Name == name);
                    human.BuyFood();
                }

                name = Console.ReadLine();
            }

            var totalFood = 0;
            foreach (var human in humans)
            {
                totalFood += human.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}
