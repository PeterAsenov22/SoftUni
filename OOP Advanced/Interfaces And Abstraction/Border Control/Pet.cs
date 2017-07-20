namespace Border_Control
{
    public class Pet:IBirthable
    {
        public string Name { get; private set; }

        public string Birthdate { get; }

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
    }
}
