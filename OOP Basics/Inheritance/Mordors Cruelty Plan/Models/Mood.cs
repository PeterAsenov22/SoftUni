namespace Mordors_Cruelty_Plan.Models
{
    public class Mood
    {
        public Mood(string desc)
        {
            this.Description = desc;
        }

        public string Description { get; set; }
    }
}
