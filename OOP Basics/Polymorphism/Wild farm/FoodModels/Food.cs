namespace Wild_farm.FoodModels
{
    public abstract class Food
    {
        private int quantity;

        protected Food(int quantity)
        {
            this.quantity = quantity;
        }

        public int FoodQuantity
        {
           get { return this.quantity; }
        }

        public abstract string Type();
    }
}
