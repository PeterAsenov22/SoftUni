using Wild_farm.FoodModels;

namespace Wild_farm.AnimalModels
{
    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        protected Animal(string animalName, string animalType, double animalWeight)
        {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalWeight = animalWeight;
            this.foodEaten = 0;
        }

        protected string AnimalType => this.animalType;
        protected string AnimalName => this.animalName;
        protected double AnimalWeight => this.animalWeight;

        protected int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten += value; }
        }
        public abstract void MakeSound();
        public abstract void Eat(Food food);
    }
}
