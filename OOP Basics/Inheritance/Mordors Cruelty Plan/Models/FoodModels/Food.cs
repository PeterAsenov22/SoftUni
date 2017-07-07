namespace Mordors_Cruelty_Plan.Models.FoodModels
{
    public abstract class Food
    {
        protected Food(int points)
        {
            this.HappinessPoints = points;
        }

        public int HappinessPoints { get; private set; }
    }
}
