namespace Border_Control
{
    public class Rebel:Human
    {
        public string Group { get; private set; }

        public Rebel(string name, int age, string group) : base(name, age)
        {
            this.Group = group;
        }

        public override void BuyFood()
        {
            this.Food += 5;
        }
    }
}
