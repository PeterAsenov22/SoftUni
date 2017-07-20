namespace Military_Elite.Soldiers
{
    public abstract class Soldier:ISoldier,IPrivate
    {
        public string ID { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public double Salary { get; private set; }

        public Soldier(string id, string firstName, string lastName, double salary)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public Soldier(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.ID} Salary: {this.Salary:F2}";
        } 
    }
}
