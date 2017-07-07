namespace Pizza_Calories
{
    using System;

    public class Dough
    {
        private double type;
        private double technique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            if (flourType != "white" && flourType != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            if (bakingTechnique != "crispy" && bakingTechnique != "chewy" && bakingTechnique != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            if (weight < 1 || weight > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            switch (flourType)
            {
                case "white":
                    this.type = 1.5;
                    break;
                case "wholegrain":
                    this.type = 1.0;
                    break;
            }

            switch (bakingTechnique)
            {
                case "crispy":
                    this.technique = 0.9;
                    break;
                case "chewy":
                    this.technique = 1.1;
                    break;
                case "homemade":
                    this.technique = 1.0;
                    break;
            }

            this.weight = weight;
        }

        public double GetCalories()
        {
            return 2 * this.weight * this.type * this.technique;
        }
    }
}
