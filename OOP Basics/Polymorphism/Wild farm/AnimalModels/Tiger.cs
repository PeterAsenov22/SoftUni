using System;
using Wild_farm.FoodModels;

namespace Wild_farm.AnimalModels
{
    public class Tiger:Felime
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food.Type() != "meat")
            {
                throw new ArgumentException("Tigers are not eating that type of food!");
            }

            base.FoodEaten = food.FoodQuantity;
        }
    }
}
