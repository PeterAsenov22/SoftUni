namespace Pizza_Calories
{
    using System;
    using System.Collections.Generic;

    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, int toppings)
        {
            this.Name = name;
            if (toppings < 0 || toppings > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }

        public IReadOnlyList<Topping> Toppings
        {
            get { return this.toppings; }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public double GetCalories()
        {
            double total = 0;
            total += this.dough.GetCalories();

            foreach (var topping in this.toppings)
            {
                total += topping.GetCalories();
            }

            return total;
        }
    }
}
