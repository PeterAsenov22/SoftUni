namespace Wild_farm.FoodModels
{
    public class Meat : Food
    {     
        public Meat(int quantity) : base(quantity)
        {
        }

        public override string Type()
        {
            return "meat";
        }
    }
}
