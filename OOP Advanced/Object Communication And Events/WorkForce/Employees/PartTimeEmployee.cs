namespace WorkForce.Employees
{
    public class PartTimeEmployee : IEmploee
    {
        private const int workingHoursPerWeek = 20;

        public PartTimeEmployee(string name)
        {
            this.Name = name;
            this.WorkingHoursPerWeek = workingHoursPerWeek;
        }

        public string Name { get; }

        public int WorkingHoursPerWeek { get; }
    }
}
