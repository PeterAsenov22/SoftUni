namespace Mordors_Cruelty_Plan.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using Mordors_Cruelty_Plan.Models.FoodModels;

    public class MoodFactory
    {
        public static Mood GetMood(List<Food> foods)
        {
            int happyPoints = foods.Sum(f => f.HappinessPoints);

            if (happyPoints < -5)
            {
                return new Mood("Angry");
            }
            if (happyPoints >= -5 && happyPoints <= 0)
            {
                return new Mood("Sad");
            }
            if (happyPoints >= 1 && happyPoints <= 15)
            {
                return new Mood("Happy");
            }

            return new Mood("JavaScript");
        }
    }
}
