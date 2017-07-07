﻿namespace Shopping_Spree
{
    using System;

    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value==null || value.Trim() == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public double Cost
        {
            get { return this.cost; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.cost = value;
            }
        }
    }
}
