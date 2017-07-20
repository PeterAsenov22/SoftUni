namespace Border_Control
{
    public abstract class Human:IEnterable,IBirthable,IBuyer
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }

        public string Birthdate { get; private set; }

        public int Food { get; protected set; }

        protected Human(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }

        protected Human(string name, int age)
        {
            Name = name;
            Age = age;
            this.Food = 0;
        }

        public virtual void BuyFood()
        {       
        }
    }
}
