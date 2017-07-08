using System;
using Wild_farm.FoodModels;

namespace Wild_farm.AnimalModels
{
    public class Mouse:Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override void Eat(Food food)
        {
            if (food.Type() != "vegetable")
            {
                throw new ArgumentException("Mouses are not eating that type of food!");
            }

            base.FoodEaten = food.FoodQuantity;
        }
    }
}
