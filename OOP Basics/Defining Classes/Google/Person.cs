namespace Google
{
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private Car car;
        private Company company;
        private List<Parent> parents;
        private List<Child> children;
        private List<Pokemon> pokemons;

        public Person()
        {
            this.Company = new Company();
            this.Car = new Car();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
            this.Pokemons = new List<Pokemon>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

        public Company Company
        {
            get { return this.company; }
            set { this.company = value; }
        }

        public List<Parent> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public List<Child> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }
    }
}
