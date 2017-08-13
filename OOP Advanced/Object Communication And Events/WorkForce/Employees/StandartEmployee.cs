namespace WorkForce.Employees
{
    public class StandartEmployee : IEmploee
    {
        private const int workingHoursPerWeek = 40;

        public StandartEmployee(string name)
        {
            this.Name = name;
            this.WorkingHoursPerWeek = workingHoursPerWeek;
        }

        public string Name { get; }

        public int WorkingHoursPerWeek { get; }
    }
}
