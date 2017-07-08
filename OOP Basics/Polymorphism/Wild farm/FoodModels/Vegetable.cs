namespace Wild_farm.FoodModels
{
    public class Vegetable:Food
    {
        public Vegetable(int quantity) : base(quantity)
        {
        }

        public override string Type()
        {
            return "vegetable";
        }
    }
}
