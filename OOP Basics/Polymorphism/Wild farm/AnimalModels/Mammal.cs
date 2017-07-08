namespace Wild_farm.AnimalModels
{
    public abstract class Mammal:Animal
    {
        private string livingRegion;
        protected string LivingRegion => this.livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight)
        {
            this.livingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{base.AnimalType}[{base.AnimalName}, {base.AnimalWeight}, {this.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
