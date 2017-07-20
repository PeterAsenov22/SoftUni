namespace Border_Control
{
    public class Citizen: Human
    {
        public Citizen(string name, int age, string id, string birthdate)
            :base(name,age,id,birthdate)
        {
        }

        public override void BuyFood()
        {
            this.Food += 10;
        }
    }
}
