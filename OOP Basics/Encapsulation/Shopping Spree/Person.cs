namespace Shopping_Spree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private double money;
        private List<string> bag;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<string>();
        }

        public IReadOnlyList<string> Bag
        {
            get { return this.bag.AsReadOnly(); }
        }

        public void AddProduct(Product product)
        {
            if (product.Cost > this.money)
            {
                Console.WriteLine($"{this.name} can't afford {product.Name}");
            }
            else
            {
                this.bag.Add(product.Name);
                this.money -= product.Cost;
                Console.WriteLine($"{this.name} bought {product.Name}");
            }       
        }

        private double Money
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == null || value.Trim() == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
    }
}
