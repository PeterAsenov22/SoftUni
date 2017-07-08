using System;
using Wild_farm.FoodModels;

namespace Wild_farm.AnimalModels
{
    public class Cat : Felime
    {
        private string breed;
        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed) : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Eat(Food food)
        {
            base.FoodEaten = food.FoodQuantity;
        }

        public override string ToString()
        {
            return $"{base.AnimalType}[{base.AnimalName}, {this.breed}, {base.AnimalWeight}, {this.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
