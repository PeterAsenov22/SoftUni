﻿namespace Mordors_Cruelty_Plan.Models
{
    using Mordors_Cruelty_Plan.Models.FoodModels;

    public class FoodFactory
    {
        public Food CreateFood(string name)
        {
            Food food;

            switch (name)
            {
                case "cram":
                    food = new Cram(2);
                    break;

                case "lembas":
                    food = new Lembas(3);
                    break;

                case "apple":
                    food = new Apple(1);
                    break;

                case "melon":
                    food = new Melon(1);
                    break;

                case "honeycake":
                    food = new HoneyCake(5);
                    break;

                case "mushrooms":
                    food = new Mushrooms(-10);
                    break;

                default:
                    food = new Misc(-1);
                    break;
            }

            return food;
        }
    }
}
