using System;
using Wild_farm.FoodModels;

namespace Wild_farm.AnimalModels
{
    public class Zebra:Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }

        public override void Eat(Food food)
        {
            if (food.Type() != "vegetable")
            {
                throw new ArgumentException("Zebras are not eating that type of food!");
            }

            base.FoodEaten = food.FoodQuantity;
        }
    }
}
