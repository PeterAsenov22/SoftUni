namespace Mordors_Cruelty_Plan
{
    using System;
    using System.Collections.Generic;
    using Mordors_Cruelty_Plan.Models;
    using Mordors_Cruelty_Plan.Models.FoodModels;

    public class StartUp
    {
        public static void Main()
        {
            var foodNames = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<Food> foods = new List<Food>();

            var ff = new FoodFactory();

            foreach (var name in foodNames)
            {
                foods.Add(ff.CreateFood(name));
            }

            Gandalf gandalf = new Gandalf(foods);

            Console.WriteLine(gandalf.ToString());
        }
    }
}
