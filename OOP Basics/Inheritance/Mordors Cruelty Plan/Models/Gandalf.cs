namespace Mordors_Cruelty_Plan.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Mordors_Cruelty_Plan.Models.FoodModels;

    public class Gandalf
    {
        private Mood mood;
        private List<Food> foods;

        public Gandalf(List<Food> foodsEaten)
        {
            this.foods = foodsEaten;
            this.mood = MoodFactory.GetMood(foodsEaten);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.foods.Sum(f => f.HappinessPoints)}");
            sb.Append(this.mood.Description);

            return sb.ToString();
        }
    }
}
