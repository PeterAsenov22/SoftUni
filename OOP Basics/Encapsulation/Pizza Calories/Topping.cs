namespace Pizza_Calories
{
    using System;

    public class Topping
    {
        private double type;
        private double technique;
        private double weight;

        public Topping(string toppingType1,double weight)
        {
            var toppingType = toppingType1.ToLower();
            if (toppingType != "meat" && toppingType != "veggies" && toppingType!="cheese" && toppingType!="sauce")
            {
                throw new ArgumentException($"Cannot place {toppingType1} on top of your pizza.");
            }           

            if (weight < 1 || weight > 50)
            {
                throw new ArgumentException($"{toppingType1} weight should be in the range [1..50].");
            }

            switch (toppingType)
            {
                case "meat":
                    this.type = 1.2;
                    break;
                case "veggies":
                    this.type = 0.8;
                    break;
                case "cheese":
                    this.type = 1.1;
                    break;
                case "sauce":
                    this.type = 0.9;
                    break;
            }

            this.weight = weight;
        }

        public double GetCalories()
        {
            return 2 * this.weight * this.type;
        }
    }
}
